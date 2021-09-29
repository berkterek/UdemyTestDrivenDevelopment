using System.Collections;
using System.Collections.Generic;
using NSubstitute;
using NUnit.Framework;
using UdemyTdd.Abstracts.Inputs;
using UdemyTdd.Controllers;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

namespace PlayModeTests.Players
{
    public class player_navmesh_movement
    {
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
    
        [UnityTest]
        public IEnumerator move_forward()
        {
            yield return LoadPlayerMovementTestScene();
        
            var player = GetPlayer();

            Vector3 startPosition = player.transform.position;
            player.Input.Direction.Returns(Vector3.forward);

            yield return new WaitForSeconds(0.3f);
        
            Assert.Greater(player.transform.position.z,startPosition.z);
        }
        
        [UnityTest]
        public IEnumerator move_back()
        {
            yield return LoadPlayerMovementTestScene();
        
            var player = GetPlayer();

            Vector3 startPosition = player.transform.position;
            player.Input.Direction.Returns(Vector3.back);

            yield return new WaitForSeconds(0.3f);
        
            Assert.Less(player.transform.position.z,startPosition.z);
        }
        
        [UnityTest]
        public IEnumerator move_right()
        {
            yield return LoadPlayerMovementTestScene();
        
            var player = GetPlayer();

            Vector3 startPosition = player.transform.position;
            player.Input.Direction.Returns(Vector3.right);

            yield return new WaitForSeconds(0.3f);
        
            Assert.Greater(player.transform.position.x,startPosition.x);
        }
        
        [UnityTest]
        public IEnumerator move_left()
        {
            yield return LoadPlayerMovementTestScene();
        
            var player = GetPlayer();

            Vector3 startPosition = player.transform.position;
            player.Input.Direction.Returns(Vector3.left);

            yield return new WaitForSeconds(0.3f);
        
            Assert.Less(player.transform.position.x,startPosition.x);
        }
    }    
}
