# HA_Passthrough

The Home Assistant control panel, rendered over your actual room. A passthrough
build for Meta Quest Pro.

## What it does

Same MQTT control surface as the VR build — `msHA/Lights/Bedroom/...` for
individual and grouped lights, `msHA/Devices/...` for room devices, subscribing
as well as publishing so the panel reflects the real state of the house.

The difference is passthrough. In full VR a smart-home panel is abstract: you
toggle "Bedroom / Alpha" and have to remember which lamp that is. With
passthrough the panel floats in the room next to the light it controls, and the
mapping stops needing to be memorised — you can watch the bulb respond while
the control is still in view.

## Scenes

| Scene | Purpose |
|---|---|
| `Passthrough_MQTT` | The passthrough control panel, live over MQTT |
| `PassthroughScene` | Passthrough setup and placement |
| `2D_TemplateMQTTTest` | Flat-screen MQTT wiring, testable without a headset |
| `FigmaImportTest` | Checking imported Figma layouts |

## Built with

Unity 2021.3.10f1 · Oculus Integration SDK · Oculus XR Plugin 3.0.2 ·
smoothMQTT · Figma Converter for Unity · Meta Quest Pro

## Related

[HomeAssistant_VR](https://github.com/mohitshukla02/HomeAssistant_VR) — the VR
build ·
[SmartHomeOS](https://github.com/mohitshukla02/SmartHomeOS) — the UI layer ·
[Test-SmoothMQTT](https://github.com/mohitshukla02/Test-SmoothMQTT) — the MQTT
groundwork

## Third-party assets

Bundles the Oculus Integration SDK, smoothMQTT, Figma Converter for Unity,
TotalJSON, and DOTween, which remain under their own licenses.

## License

Copyright © 2026 Mohit Shukla. All rights reserved.

This repository is made publicly viewable for portfolio and demonstration
purposes only. No license is granted to use, copy, modify, merge, publish,
distribute, sublicense, or sell copies of HA_Passthrough or any part of
it, in whole or in part, without prior written permission from the
copyright holder.
