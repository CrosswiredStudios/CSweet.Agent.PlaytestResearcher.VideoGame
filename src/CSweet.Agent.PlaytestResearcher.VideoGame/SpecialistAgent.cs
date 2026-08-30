using CSweet.VideoGame.AgentKit;

namespace CSweet.Agent.PlaytestResearcher.VideoGame;

public sealed class SpecialistAgent : VideoGameSpecialistAgentBase
{
    public override string AgentId => "com.csweet.video-game-playtest-researcher";
    public override string Version => "1.0.0";
    public override string PrimaryCapability => "video-game.playtest-researcher.execute.v1";
    protected override string RoleKey => "playtest-researcher";
    protected override string ArtifactTypeKey => "video-game.playtest-plan.v1";
    protected override string RolePrompt => "Own consent-governed player research questions, recruitment criteria, scripts, evidence, interpretation, and actionable findings. Separate observation from inference.";
    protected override IReadOnlyList<string> RequiredSections => ["Research Questions", "Participants", "Consent and Privacy", "Protocol", "Measures", "Analysis", "Actionable Findings"];
}

