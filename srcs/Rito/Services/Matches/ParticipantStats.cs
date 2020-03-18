using Newtonsoft.Json;

namespace Rito.Services.Matches
{
    public sealed class ParticipantStats
    {
        [JsonProperty]
        public bool FirstBloodAssist { get; private set; }
        
        [JsonProperty]
        public long VisionScore { get; private set; }
        
        [JsonProperty]
        public long MagicDamageDealtToChampions { get; private set; }
        
        [JsonProperty]
        public long DamageDealtToObjectives { get; private set; }
        
        [JsonProperty]
        public int TotalTimeCrowdControlDealt { get; private set; }
        
        [JsonProperty]
        public int LongestTimeSpentLiving { get; private set; }
        
        [JsonProperty]
        public int TripleKills { get; private set; }
        
        [JsonProperty]
        public int NodeNeutralizeAssist { get; private set; }
        
        [JsonProperty]
        public int PlayerScore9 { get; private set; }
        
        [JsonProperty]
        public int PlayerScore8 { get; private set; }
        
        [JsonProperty]
        public int Kills { get; private set; }
        
        [JsonProperty]
        public int PlayerScore1 { get; private set; }
        
        [JsonProperty]
        public int PlayerScore0 { get; private set; }
        
        [JsonProperty]
        public int PlayerScore2 { get; private set; }
        
        [JsonProperty]
        public int PlayerScore3 { get; private set; }
        
        [JsonProperty]
        public int PlayerScore4 { get; private set; }
        
        [JsonProperty]
        public int PlayerScore5 { get; private set; }
        
        [JsonProperty]
        public int PlayerScore6 { get; private set; }
        
        [JsonProperty]
        public int PlayerScore7 { get; private set; }
        
        [JsonProperty]
        public int TotalScoreRank { get; private set; }
        
        [JsonProperty]
        public int NeutralMinionsKilled { get; private set; }
        
        [JsonProperty]
        public long DamageDealtToTurrets { get; private set; }
        
        [JsonProperty]
        public long PhysicalDamageDealtToChampions { get; private set; }
        
        [JsonProperty]
        public int NodeCapture { get; private set; }
        
        [JsonProperty]
        public int LargestMultiKill { get; private set; }
        
        [JsonProperty]
        public int TotalUnitsHealed { get; private set; }
        
        [JsonProperty]
        public int WardsKilled { get; private set; }
        
        [JsonProperty]
        public int LargestCriticalStrike { get; private set; }
        
        [JsonProperty]
        public int LargestKillingSpree { get; private set; }
        
        [JsonProperty]
        public int QuadraKills { get; private set; }
        
        [JsonProperty]
        public int TeamObjective { get; private set; }
        
        [JsonProperty]
        public int MagicDamagedDealt { get; private set; }
        
        [JsonProperty]
        public int Item0 { get; private set; }
        
        [JsonProperty]
        public int Item1 { get; private set; }
        
        [JsonProperty]
        public int Item2 { get; private set; }
        
        [JsonProperty]
        public int Item3 { get; private set; }
        
        [JsonProperty]
        public int Item4 { get; private set; }
        
        [JsonProperty]
        public int Item5 { get; private set; }
        
        [JsonProperty]
        public int Item6 { get; private set; }
        
        [JsonProperty]
        public int NeutralMinionsKilledTeamJungle { get; private set; }
        
        [JsonProperty]
        public long DamageSelfMitigated { get; private set; }
        
        [JsonProperty]
        public long MagicalDamageTaken { get; private set; }
        
        [JsonProperty]
        public bool FirstInhibitorKill { get; private set; }
        
        [JsonProperty]
        public long TrueDamageTaken { get; private set; }
        
        [JsonProperty]
        public int NodeNeutralize { get; private set; }
        
        [JsonProperty]
        public int Assists { get; private set; }
        
        [JsonProperty]
        public int CombatPlayerScore { get; private set; }
        
        [JsonProperty]
        public int GoldSpent { get; private set; }
        
        [JsonProperty]
        public long TrueDamageDealt { get; private set; }
        
        [JsonProperty]
        public int ParticipantId { get; private set; }
        
        [JsonProperty]
        public long TotalDamageTaken { get; private set; }
        
        [JsonProperty]
        public long PhysicalDamageDealt { get; private set; }
        
        [JsonProperty]
        public int SightWardsBought { get; private set; }
        
        [JsonProperty]
        public long TotalDamageDealtToChampions { get; private set; }
        
        [JsonProperty]
        public long PhysicalDamageTaken { get; private set; }
        
        [JsonProperty]
        public int TotalPlayerScore { get; private set; }
        
        [JsonProperty]
        public bool Win { get; private set; }
        
        [JsonProperty]
        public int ObjectivePlayerScore { get; private set; }
        
        [JsonProperty]
        public long TotalDamageDealt { get; private set; }
        
        [JsonProperty]
        public int NeutralMinionsKilledEnemyJungle { get; private set; }
        
        [JsonProperty]
        public int Deaths { get; private set; }
        
        [JsonProperty]
        public int WardsPlaced { get; private set; }
        
        [JsonProperty]
        public int PerkSubStyle { get; private set; }
        
        [JsonProperty]
        public int TurretKills { get; private set; }
        
        [JsonProperty]
        public bool FirstBloodKill { get; private set; }
        
        [JsonProperty]
        public long TrueDamageDealtToChampions { get; private set; }
        
        [JsonProperty]
        public int GoldEarned { get; private set; }
        
        [JsonProperty]
        public int KillingSprees { get; private set; }
        
        [JsonProperty]
        public int UnrealKills { get; private set; }
        
        [JsonProperty]
        public int AltarsCaptured { get; private set; }
        
        [JsonProperty]
        public bool FirstTowerAssist { get; private set; }
        
        [JsonProperty]
        public bool FirstTowerKill { get; private set; }
        
        [JsonProperty]
        public int ChampLevel { get; private set; }
        
        [JsonProperty]
        public int DoubleKills { get; private set; }
        
        [JsonProperty]
        public int NodeCaptureAssist { get; private set; }
        
        [JsonProperty]
        public int InhibitorKills { get; private set; }
        
        [JsonProperty]
        public bool FirstInhibitorAssist { get; private set; }
        
        [JsonProperty]
        public int VisionWardsBoughtInGame { get; private set; }
        
        [JsonProperty]
        public int AltarsNeutralized { get; private set; }
        
        [JsonProperty]
        public int PentaKills { get; private set; }
        
        [JsonProperty]
        public long TotalHeal { get; private set; }
        
        [JsonProperty]
        public int TotalMinionsKilled { get; private set; }
        
        [JsonProperty]
        public long TimeCCingOthers { get; private set; }
    }
}