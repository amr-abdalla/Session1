using UnityEngine;

public class CollectableRotator : MonoBehaviour
{
	public Vector3 rotationPerSecond = new Vector3(15, 30, 45);

	void Update()
	{
		transform.Rotate(rotationPerSecond * Time.deltaTime);
	}
}
