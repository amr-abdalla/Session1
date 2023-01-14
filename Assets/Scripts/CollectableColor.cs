using UnityEngine;

public class CollectableColor : MonoBehaviour
{
	public Color colorStart = Color.yellow;
	public Color colorEnd = Color.green;
	public float duration = 1f;
	private Renderer rend;

	void Start()
	{
		rend = GetComponent<Renderer>();
	}

	void Update()
	{
		float lerp = Mathf.PingPong(Time.time, duration) / duration;
		rend.material.color = Color.Lerp(colorStart, colorEnd, lerp);
	}
}
