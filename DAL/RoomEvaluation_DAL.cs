using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RoomEvaluation_DAL
    {
        HotelManagementDataContext db = new HotelManagementDataContext();

        public IQueryable<RoomEvaluation_ET> getAllRoomEvaluation()
        {
            var query = from re in db.RoomEvaluations
                        join r in db.Rooms on re.RoomID equals r.RoomID
                        select new RoomEvaluation_ET
                        {
                            EvaluationID = re.EvaluationID,
                            RoomID = r.RoomID,
                            EvaluationDate = re.EvaluationDate,
                            CleanlinessScore = re.CleanlinessScore,
                            ComfortScore = re.ComfortScore,
                            ServiceScore = re.ServiceScore,
                            FacilitiesScore = re.FacilitiesScore,
                            LocationScore = re.LocationScore,
                            SafetyScore = re.SafetyScore,
                            LuxuryScore = re.LuxuryScore,
                            TechnologyScore = re.TechnologyScore,
                            StaffScore = re.StaffScore,
                            Evaluator = re.Evaluator
                        };
            return query;
        }
        public IQueryable<Room_ET> getIDNameRoom()
        {
            var query = from r in db.Rooms
                        select new Room_ET
                        {
                            RoomID = r.RoomID,
                            RoomName = r.RoomName
                        };
            return query;
        }

        public bool addRoomEvaluation(RoomEvaluation_ET roomEvaluation)
        {
            try
            {
                RoomEvaluation newEvaluation = new RoomEvaluation
                {
                    RoomID = roomEvaluation.RoomID,
                    EvaluationDate = roomEvaluation.EvaluationDate,
                    CleanlinessScore = roomEvaluation.CleanlinessScore,
                    ComfortScore = roomEvaluation.ComfortScore,
                    ServiceScore = roomEvaluation.ServiceScore,
                    FacilitiesScore = roomEvaluation.FacilitiesScore,
                    LocationScore = roomEvaluation.LocationScore,
                    SafetyScore = roomEvaluation.SafetyScore,
                    LuxuryScore = roomEvaluation.LuxuryScore,
                    TechnologyScore = roomEvaluation.TechnologyScore,
                    StaffScore = roomEvaluation.StaffScore,
                    Evaluator = roomEvaluation.Evaluator
                };
                db.RoomEvaluations.InsertOnSubmit(newEvaluation);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string UpdateOfficialRoom(RoomEvaluation_ET et)
        {
            try
            {
                int totalScore =
                    (et.CleanlinessScore ?? 0) +
                    (et.ComfortScore ?? 0) +
                    (et.ServiceScore ?? 0) +
                    (et.FacilitiesScore ?? 0) +
                    (et.LocationScore ?? 0) +
                    (et.SafetyScore ?? 0) +
                    (et.LuxuryScore ?? 0) +
                    (et.TechnologyScore ?? 0) +
                    (et.StaffScore ?? 0);

                string officialStatus;

                if (totalScore >= 70)
                    officialStatus = "Đã chứng thực";
                else{
                    officialStatus = "Không đạt yêu cầu";

                }


                var room = db.Rooms.SingleOrDefault(r => r.RoomID == et.RoomID);
                if (room != null)
                {
                    room.Official = officialStatus;
                    db.SubmitChanges();
                }

                return officialStatus;
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }

        public bool DeleteRoomEvaluation(int evaluationID)
        {
            try
            {
                var evaluation = db.RoomEvaluations.FirstOrDefault(re => re.EvaluationID == evaluationID);

                if (evaluation == null)
                    return false; 

                db.RoomEvaluations.DeleteOnSubmit(evaluation);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false; 
            }
        }

        public bool UpdateRoomEvaluation(RoomEvaluation_ET et)
        {
            try
            {
                var existingEvaluation = db.RoomEvaluations
                    .FirstOrDefault(e => e.EvaluationID == et.EvaluationID);

                if (existingEvaluation == null)
                    return false;

                existingEvaluation.RoomID = et.RoomID;
                existingEvaluation.EvaluationDate = et.EvaluationDate;
                existingEvaluation.CleanlinessScore = et.CleanlinessScore;
                existingEvaluation.ComfortScore = et.ComfortScore;
                existingEvaluation.ServiceScore = et.ServiceScore;
                existingEvaluation.FacilitiesScore = et.FacilitiesScore;
                existingEvaluation.LocationScore = et.LocationScore;
                existingEvaluation.SafetyScore = et.SafetyScore;
                existingEvaluation.LuxuryScore = et.LuxuryScore;
                existingEvaluation.TechnologyScore = et.TechnologyScore;
                existingEvaluation.StaffScore = et.StaffScore;
                existingEvaluation.Evaluator = et.Evaluator;

                int? totalScore = et.CleanlinessScore + et.ComfortScore + et.ServiceScore +
                                 et.FacilitiesScore + et.LocationScore + et.SafetyScore +
                                 et.LuxuryScore + et.TechnologyScore + et.StaffScore;

                var room = db.Rooms.FirstOrDefault(r => r.RoomID == et.RoomID);
                if (room != null)
                {
                    room.Official = totalScore >= 70 ? "Đã chứng thực" : "Không đạt tiêu chuẩn";
                }

                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
