using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Core.Domain
{
    public abstract class AggregateRoot
    {
        protected Guid _id;

        public Guid Id { get { return _id; } }

        public int Version { get; set; } = -1;

    }
}
