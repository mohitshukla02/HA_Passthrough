using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HomeAssistant
{
    public class SensorEntity : Entity
    {
        public SensorEntity(string entityId) : base("sensor" , entityId)
        {

        }
    }
}
