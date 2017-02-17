using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayAgainLevel : MonoBehaviour {
	SceneManager sm;

	// respond on collisions
	void OnCollisionEnter(Collision newCollision)
	{
		// only do stuff if hit by a projectile
		if (newCollision.gameObject.tag == "Projectile") {
			// reload the active level
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}
}
