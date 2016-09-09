using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StatusView : MonoBehaviour {

	private static string Not_Connected = "Not connected";
	private static string Con_Disconnected = "Disconnected";
	private static string Con_Connected = "Connected";
	private static string Connecting = "Connecting";
	private static string Status = "Status: ";
	private Text StatusText;

	private string _currentStatus;
	public string currentStatus {
		get { return _currentStatus;}
		set { 
			_currentStatus = Status + value;
			StatusText.text = _currentStatus;
		}
	} 

	// Use this for initialization
	void Awake () {
		StatusText = GetComponent<Text> ();
		NotConnected ();
	}
	
	public void Connect() {
		currentStatus = Connecting;
	}
		
	public void Connected() {
		currentStatus = Con_Connected;
	}

	public void Disconnected() {
		currentStatus = Con_Disconnected;
	}

	public void NotConnected(){
		currentStatus = Not_Connected;
	}
}
