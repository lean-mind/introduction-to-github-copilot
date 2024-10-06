namespace Conversiones;

public class MultiDisciplinarTeamCreator
{
public List<List<object>> createWith(List<object> students)
{
    var teams = new List<List<object>>();
    var groupedStudents = students
        .GroupBy(student => student.GetType().GetProperty("bachellor").GetValue(student, null))
        .Select(g => g.ToList())
        .ToList();

    if (groupedStudents.All(group => group.Count == 1))
    {
        teams.Add(students);
        return teams;
    }

    while (groupedStudents.Count > 0)
    {
        var team = new List<object>();
        foreach (var group in groupedStudents.ToList())
        {
            if (team.Count < 2)
            {
                var student = group.First();
                team.Add(student);
                group.Remove(student);

                if (group.Count == 0)
                {
                    groupedStudents.Remove(group);
                }
            }
        }

        teams.Add(team);
    }

    return teams;
}
}