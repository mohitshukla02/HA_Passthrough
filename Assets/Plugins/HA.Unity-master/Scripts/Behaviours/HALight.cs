using HomeAssistant;
using UnityEngine;

public class HALight : ActivationBehaviour
{
    public string entityId;
    public GameObject sceneLight;
    public int red=0;
    public int green=255;
    public int blue=0;
    
    private LightEntity _lightEntity;

    void Start()
    {
        _lightEntity = new LightEntity(entityId);

        if (_lightEntity != null) // found?
        {
            // grab current state
            _lightEntity.IsOn(on =>
            {
                if(sceneLight != null)
                    sceneLight.SetActive(on);
            });
        }
    }

    public override void OnActivate()
    {
        if (_lightEntity != null)
        {
            _lightEntity.Toggle(on =>
            {
                if (sceneLight != null)
                {
                    sceneLight.SetActive(on);

                    Debug.Log("Red:" + red);
                    Debug.Log("Green:" + green);
                    Debug.Log("Blue:" + blue);
                    _lightEntity.TurnOnWithColor(red, green, blue);
                }
            });
        }
    }
}
