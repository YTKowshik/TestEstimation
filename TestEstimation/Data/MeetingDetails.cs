using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestEstimation.Data
{
    public class MeetingDetails
    {
        #region Private members
        private CreateMeetingContext dbContext;
        #endregion
        #region Constructor
        public MeetingDetails(CreateMeetingContext dbContext)
        {
            this.dbContext = dbContext;
        }
        #endregion
        public void CreateMeeting(EstimationModels.Meeting meeting)
        {
            dbContext.Meetings.Add(meeting);
            dbContext.SaveChanges();
        }

        public async Task<List<EstimationModels.Meeting>> GetMeetingsAsync()
        {
            return await dbContext.Meetings.ToListAsync();
        }
    }
}
