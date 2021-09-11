# Unity-Github-Action
A repository to showcase github action with Unity. The Unity project is empty.

This repository has three workflows :
- "activation.yml" which needs to be executed at the start of your project to get your license and set the "UNITY_LICENSE" variable in github secret. 🔑
- "test.yml" which verifies for each push that your project run all of its unit tests right, and that the project can be built. ⚙ 
- "build.yml" which is executed when creating a new release, testing once again your Unity project, and then building it for Windonwsx64, and attaching the .zip to your release. 🔨

Thanks to @webbertaken ( https://game.ci/ )

Tutorials I used :
https://isaacbroyles.com/gamedev/2020/07/04/unity-github-actions.html
https://bearandhammer.net/2020/06/13/github-actions-unity-3d/
