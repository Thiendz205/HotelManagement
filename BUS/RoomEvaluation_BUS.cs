using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class RoomEvaluation_BUS
    {
        RoomEvaluation_DAL roomEvaluation_DAL = new RoomEvaluation_DAL();
        public IQueryable<RoomEvaluation_ET> getAllRoomEvaluation()
        {
            return roomEvaluation_DAL.getAllRoomEvaluation();
        }
        public IQueryable<Room_ET> getIDNameRoom()
        {
            return roomEvaluation_DAL.getIDNameRoom();
        }


        public bool addRoomEvaluation(RoomEvaluation_ET roomEvaluation)
        {
            return roomEvaluation_DAL.addRoomEvaluation(roomEvaluation);
        }

        public string UpdateOfficialRoom(RoomEvaluation_ET et)
        {
            return roomEvaluation_DAL.UpdateOfficialRoom(et);
        }

        public bool DeleteRoomEvaluation(int evaluationID)
        {
            return roomEvaluation_DAL.DeleteRoomEvaluation(evaluationID);
        }
        public bool UpdateRoomEvaluation(RoomEvaluation_ET et)
        {
            return roomEvaluation_DAL.UpdateRoomEvaluation(et);
        }


    }
}
