using UnityEngine;
using System.Collections;

public class ControlPanelController : MonoBehaviour
{
	public GameObject panel;
	private bool visible = false;

	public void ChangePanel()
	{
		visible = !visible;
		panel.gameObject.SetActive(visible);
	}
}
