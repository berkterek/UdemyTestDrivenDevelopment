using System.Collections;
using System.Collections.Generic;
using NSubstitute;
using NUnit.Framework;
using UdemyTdd.Abstracts.Inputs;
using UdemyTdd.Controllers;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

namespace PlayModeTests.Players.Movements
{
    public class player_navmesh_movement
    {
        float _waitTime = 0.5f;
        
        PlayerNavmeshController GetPlayer()
        {
            var player = GameObject.FindObjectOfType<PlayerNavmeshController>();
            player.Input = Substitute.For<IMouseInputReader>();
            return player;
        }

        IEnumerator LoadPlayerMovementTestScene()
        {
            yield return SceneManager.LoadSceneAsync("PlayerNavmeshMovementTest");
        }

        Camera GetSceneCamera()
        {
            return Camera.main;
        }
    
        [UnityTest]
        public IEnumerator move_forward()
        {
            yield return LoadPlayerMovementTestScene();
        
            var player = GetPlayer();
            var camera = GetSceneCamera();

            Vector3 startPosition = player.transform.position;

            player.Input.IsLeftButtonDown.Returns(true);
            Vector3 screenPosition = camera.WorldToScreenPoint(Vector3.forward * 3f);
            player.Input.Direction.Returns(screenPosition);
            
            yield return new WaitForEndOfFrame();
            
            player.Input.IsLeftButtonDown.Returns(false);

            yield return new WaitForSeconds(_waitTime);
        
            Assert.Greater(player.transform.position.z,startPosition.z);
        }
        
        [UnityTest]
        public IEnumerator move_back()
        {
            yield return LoadPlayerMovementTestScene();
        
            var player = GetPlayer();
            var camera = GetSceneCamera();

            Vector3 startPosition = player.transform.position;
            
            player.Input.IsLeftButtonDown.Returns(true);
            Vector3 screenPosition = camera.WorldToScreenPoint(Vector3.back * 3f);
            player.Input.Direction.Returns(screenPosition);
            
            yield return new WaitForEndOfFrame();
            
            player.Input.IsLeftButtonDown.Returns(false);

            yield return new WaitForSeconds(_waitTime);
        
            Assert.Less(player.transform.position.z,startPosition.z);
        }
        
        [UnityTest]
        public IEnumerator move_right()
        {
            yield return LoadPlayerMovementTestScene();
        
            var player = GetPlayer();
            var camera = GetSceneCamera();

            Vector3 startPosition = player.transform.position;
            
            player.Input.IsLeftButtonDown.Returns(true);
            Vector3 screenPosition = camera.WorldToScreenPoint(Vector3.right * 3f);
            player.Input.Direction.Returns(screenPosition);
            
            yield return new WaitForEndOfFrame();
            
            player.Input.IsLeftButtonDown.Returns(false);

            yield return new WaitForSeconds(_waitTime);
        
            Assert.Greater(player.transform.position.x,startPosition.x);
        }
        
        [UnityTest]
        public IEnumerator move_left()
        {
            yield return LoadPlayerMovementTestScene();
        
            var player = GetPlayer();
            var camera = GetSceneCamera();

            Vector3 startPosition = player.transform.position;
            
            player.Input.IsLeftButtonDown.Returns(true);
            Vector3 screenPosition = camera.WorldToScreenPoint(Vector3.left * 3f);
            player.Input.Direction.Returns(screenPosition);
            
            yield return new WaitForEndOfFrame();
            
            player.Input.IsLeftButtonDown.Returns(false);

            yield return new WaitForSeconds(_waitTime);
        
            Assert.Less(player.transform.position.x,startPosition.x);
        }
    }    
}
