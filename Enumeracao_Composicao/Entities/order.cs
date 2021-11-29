using System;
using Enumeracao_Composicao.Entities.Enums;

namespace Enumeracao_Composicao.Entities

{
    class order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public orderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                +", "
                + Moment
                +", "
                +Status;
        }
    }
}
