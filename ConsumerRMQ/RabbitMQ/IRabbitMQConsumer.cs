using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumerRMQ.RabbitMQ
{
    public interface IRabbitMQConsumer
    {
        public void GetMessage();

    }
}
