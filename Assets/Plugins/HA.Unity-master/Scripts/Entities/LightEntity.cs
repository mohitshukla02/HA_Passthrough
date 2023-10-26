
using System;

namespace HomeAssistant
{
    public class LightEntity : Entity
    {
        public LightEntity(string entityId) : base("light", entityId)
        {
            if (!Id.StartsWith("light."))
                Id = "light." + Id;
        }

        public void IsOn(Action<bool> handler = null) => GetState(result => handler?.Invoke(result?.State == "on"));
        public void TurnOn() => CallService("turn_on");
        public void TurnOff() => CallService("turn_off");
        public void TurnOnWithBrightness(int brightness) => CallService("turn_on", new { brightness });
        public void TurnOnWithColor(int red, int green, int blue) => CallService("turn_on", new
        {
            rgb_color = new[] {
          red, green, blue}
        });
        public void Toggle(Action<bool> handler = null) => IsOn(on =>
        {
            if (on)
            {

                TurnOff();
            }
            else
            {
                TurnOnWithColor(255, 0, 0);
                //TurnRed();

                handler?.Invoke(!on);
            }
        });
    }
}
