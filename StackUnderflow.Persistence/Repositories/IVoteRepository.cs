﻿#region

using StackUnderflow.Model.Entities;
using StackUnderflow.Persistence.Entities;

#endregion

namespace StackUnderflow.Persistence.Repositories
{
    public interface IVoteRepository : IRepository<VoteOnQuestion>
    {
        void AddVote(User user, Question question, VoteType voteType);
        VoteCount GetVoteCount(int questionId);
        VoteOnQuestion GetVote(User user, Question question);
    }
}