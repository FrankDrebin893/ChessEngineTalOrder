using System;
using System.Collections.Generic;
using System.Text;

namespace TalOrder.Domain.Entities
{
    public interface IPositionEvaluator
    {
        EvaluationResult EvaluatePosition(Position position);
    }
}
