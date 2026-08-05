using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private string _file = Path.Combine(AppContext.BaseDirectory, "goals.txt");

    public void Start()
    {
        LoadGoals();
        while (true)
        {
            Console.WriteLine("1. List Goals");
            Console.WriteLine("2. Create Goal");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Display Info");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            var command = Console.ReadLine();
            if (command == "1") ListGoals();
            else if (command == "2") CreateGoal();
            else if (command == "3") RecordEvent();
            else if (command == "4") SaveGoals();
            else if (command == "5") LoadGoals();
            else if (command == "6") DisplayInfo();
            else if (command == "7") { SaveGoals(); break; }
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Score: {_score}");
        Console.WriteLine($"Goals: {_goals.Count}");
    }

    public void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals.");
            return;
        }
        for (int i = 0; i < _goals.Count; i++)
        {
            var goal = _goals[i];
            var mark = goal.IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{i+1}. {mark} {goal.GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("type: 1=Simple 2=Eternal 3=Checklist");
        var typeInput = Console.ReadLine();
        Console.Write("name: "); var name = Console.ReadLine() ?? "";
        Console.Write("desc: "); var description = Console.ReadLine() ?? "";
        Console.Write("points: "); var points = int.TryParse(Console.ReadLine(), out var parsedPoints) ? parsedPoints : 0;
        if (typeInput == "1") _goals.Add(new SimpleGoal(name, description, points));
        else if (typeInput == "2") _goals.Add(new EternalGoal(name, description, points));
        else if (typeInput == "3")
        {
            Console.Write("target: "); var target = int.TryParse(Console.ReadLine(), out var parsedTarget) ? parsedTarget : 1;
            Console.Write("bonus: "); var bonus = int.TryParse(Console.ReadLine(), out var parsedBonus) ? parsedBonus : 0;
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

    public void RecordEvent()
    {
        ListGoals();
        Console.Write("which: ");
        var success = int.TryParse(Console.ReadLine(), out var parsedIndex);
        if (!success || parsedIndex < 1 || parsedIndex > _goals.Count) return;
        var selectedGoal = _goals[parsedIndex - 1];
        var awardedPoints = selectedGoal.RecordEvent();
        _score += awardedPoints;
    }

    public void SaveGoals()
    {
        var lines = new List<string> { $"Score|{_score}" };
        foreach (var goal in _goals) lines.Add(goal.GetStringRepresentation());
        File.WriteAllLines(_file, lines);
    }

    public void LoadGoals()
    {
        if (!File.Exists(_file)) return;
        _goals.Clear(); _score = 0;
        foreach (var line in File.ReadAllLines(_file))
        {
            var parts = line.Split('|');
            if (parts.Length == 0) continue;
            if (parts[0] == "Score") { _score = int.TryParse(parts[1], out var savedScore) ? savedScore : 0; continue; }
            if (parts[0] == "Simple" && parts.Length >= 5)
            {
                var simplePoints = int.TryParse(parts[3], out var parsedSimplePoints) ? parsedSimplePoints : 0;
                var simpleGoal = new SimpleGoal(parts[1], parts[2], simplePoints);
                if (bool.TryParse(parts[4], out var isCompleteParsed)) simpleGoal.IsCompleteOverride = isCompleteParsed;
                _goals.Add(simpleGoal);
            }
            else if (parts[0] == "Eternal" && parts.Length >= 4)
            {
                var eternalPoints = int.TryParse(parts[3], out var parsedEternalPoints) ? parsedEternalPoints : 0;
                _goals.Add(new EternalGoal(parts[1], parts[2], eternalPoints));
            }
            else if (parts[0] == "Checklist" && parts.Length >= 7)
            {
                var checklistPoints = int.TryParse(parts[3], out var parsedChecklistPoints) ? parsedChecklistPoints : 0;
                var checklistTarget = int.TryParse(parts[5], out var parsedChecklistTarget) ? parsedChecklistTarget : 1;
                var checklistBonus = int.TryParse(parts[6], out var parsedChecklistBonus) ? parsedChecklistBonus : 0;
                var checklistGoal = new ChecklistGoal(parts[1], parts[2], checklistPoints, checklistTarget, checklistBonus);
                if (int.TryParse(parts[4], out var amountCompletedParsed)) checklistGoal.AmountCompleted = amountCompletedParsed;
                _goals.Add(checklistGoal);
            }
        }
    }
}
