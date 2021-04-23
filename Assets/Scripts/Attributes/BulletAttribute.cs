using UnityEngine;
using System.Collections;

[AddComponentMenu("Playground/Attributes/Bullet")]
public class BulletAttribute : MonoBehaviour
{
	[HideInInspector]
	public int playerId;

	public Transform derecho;

	public Transform izquierdo;

	public Transform dercentro;

	public GameObject disparo;

	//This will create a dialog window asking for which dialog to add
	private void Reset()
	{
		Utils.Collider2DDialogWindow(this.gameObject, true);
		Destroy(gameObject,3);
	}
}
