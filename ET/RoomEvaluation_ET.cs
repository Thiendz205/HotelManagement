using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class RoomEvaluation_ET
    {
        public RoomEvaluation_ET() { }

        public RoomEvaluation_ET(int evaluationID, string roomID, DateTime evaluationDate, int cleanlinessScore, int comfortScore, int serviceScore, 
            int facilitiesScore, int locationScore, int safetyScore, int luxuryScore, int technologyScore, int staffScore, string evaluator)
        {
            EvaluationID = evaluationID;
            RoomID = roomID;
            EvaluationDate = evaluationDate;
            CleanlinessScore = cleanlinessScore;
            ComfortScore = comfortScore;
            ServiceScore = serviceScore;
            FacilitiesScore = facilitiesScore;
            LocationScore = locationScore;
            SafetyScore = safetyScore;
            LuxuryScore = luxuryScore;
            TechnologyScore = technologyScore;
            StaffScore = staffScore;
            Evaluator = evaluator;
        }

        public int EvaluationID { get; set; }
        public string RoomID { get; set; }
        public DateTime EvaluationDate { get; set; }
        public int? CleanlinessScore { get; set; }
        public int? ComfortScore { get; set; }
        public int? ServiceScore { get; set; }
        public int? FacilitiesScore { get; set; }
        public int? LocationScore { get; set; }
        public int? SafetyScore { get; set; }
        public int? LuxuryScore { get; set; }
        public int? TechnologyScore { get; set; }
        public int? StaffScore { get; set; }
        public string Evaluator { get; set; }

    }
}
