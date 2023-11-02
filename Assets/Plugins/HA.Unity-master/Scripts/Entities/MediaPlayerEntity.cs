
using System;

namespace HomeAssistant
{
    public class MediaPlayerEntity : Entity
    {
        public MediaPlayerEntity(string entityId) : base("mediaplayer", entityId)
        {
            if (!Id.StartsWith("mediaplayer."))
            {
                Id = "mediaplayer." + Id;
            }

        /*public void IsOn(Action<bool> handler = null)
            {
                GetState(result => handler?.Invoke(result?.State == "on"));
            }
        */

        //public void TurnOn() => CallServiceMain("turn_on");
        //public void TurnOff() => CallServiceMain("turn_off");

        /*public void Toggle(Action<bool> handler = null)
            {
                IsOn(on =>
                {
                    if (on)
                        {

                           TurnOff();
                        }
                    else
                        {
                           TurnOn();
                    //TurnRed();

                            handler?.Invoke(!on);
                        }
                });
            }
        */
        }
    }
}