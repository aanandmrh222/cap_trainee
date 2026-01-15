using System;

namespace UltraEnterpriseSDLC;

public enum RiskLevel
{
    Low, Medium, High, Critical
}

public enum SDLCStage
{
    Backlog=0,
    Requirement=1, 
    Design=2, 
    Development=3, 
    CodeReview=4, 
    Testing=5, 
    UAT=6,
    Deployment=7,
    Maintenance=8
}

public sealed class Requirement
{
    public int Id{get;}
    public string Title {get;}
    public RiskLevel Risk{get;}

    public Requirement(int id, string title, RiskLevel risk)
    {
        Id = id;
        Title = title;
        Risk = risk;
    }
}

public sealed class WorkItem
{
    public int Id{get;}
    public string Name{get;}
    public SDLCStage Stage{get; set;}
    public HashSet<int> DependencyIds{get;}
    public WorkItem(int id, string name, SDLCStage stage)
    {
        Id = id;
        Name = name;
        Stage = stage;
        DependencyIds = new HashSet<int>();
    }
}

public sealed class BuildSnapshot
{
    public string Version {get;}
    public DateTime Timestamp  {get;}
    public BuildSnapshot(string version)
    {
        Version = version;
        Timestamp = DateTime.Now;
    }
}

public sealed class AuditLog
{
    public DateTime Time {get;}
    public string Action {get;}
    public BuildSnapshot(string action)
    {
        Timestamp = DateTime.Now;
        Action = action;
    }
}

public sealed class QualityMetric
{
    public string Name {get;}
    public double Score {get;}
    public QualityMetric(string name, double score)
    {
        Name = name;
        Score = score;
    }
}

public class EnterpriseSDLCEngine
{
    private List<Requirement> _requirements;
    private Dictionary<int, WorkItem> _workItemRegistry;
    private SortedDictionary<SDLCStage, List<WorkItem>> _stageBoard;
    private Queue<WorkItem> _executionQueue;
    private Stack<BuildSnapshot> _rollbackStack;
    private HashSet<string> _uniqueTestSuites;
    private LinkedList<AuditLog> _auditLedger;
    private SortedList<double, QualityMetric> _releaseScoreboard;

    private int _requirementCounter;
    private int _workItemCounter;

    public EnterpriseSDLCEngine()
    {
        _requirements = new List<Requirement>();
        _workItemRegistry = new Dictionary<int, WorkItem>();
        _stageBoard = new SortedDictionary<SDLCStage, List<WorkItem>>();

        foreach(SDLCStage stage in Enum.GetValues(typeof(SDLCStage)))
        {
            _stageBoard[stage] = new List<WorkItem>();
        }

        _executionQueue = new Queue<WorkItem>();
        _rollbackStack = new Stack<BuildSnapshot>();
        _uniqueTestSuites  = new HashSet<string>();
        _auditLedger = new LinkedList<AuditLog>();
        _releaseScoreboard = new SortedList<double, QualityMetric>();

        _requirementCounter = 0;
        _workItemCounter = 0;

    }
}