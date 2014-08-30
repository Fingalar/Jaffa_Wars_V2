using UnityEngine;
using System.Collections;

public class TargetTouched : MonoBehaviour {

	public GameObject explosion;
	private	Object expl;

	IEnumerator	OnCollisionEnter(Collision target)
	{
		if (target.gameObject.name == "DeathGlidder")
		{
			expl = Instantiate(explosion, target.transform.position, target.transform.rotation);
			Destroy(target.gameObject);
			yield  return new WaitForSeconds(1);
			Destroy(expl);
		}
	}
}
