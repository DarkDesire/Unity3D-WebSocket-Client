using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class WebSocketHandler : MonoBehaviour {

	[SerializeField]
	private StatusView statusView;
	[SerializeField]
	private InputField addressInputField;
	[SerializeField]
	private InputField channelInputField;
	[SerializeField]
	private InputField nameInputField;
	[SerializeField]
	private InputField messageInputField;
	[SerializeField]
	private TextAreaView textAreaView;

	private WebSocket webSocket;

	public void ConnectViaWS ()
	{
		StartCoroutine("WebSocketCoroutine");
	}

	public void DisconnectWS()
	{
		StopCoroutine ("WebSocketCoroutine");

		webSocket.Close();

		statusView.Disconnected ();
	}
		
	IEnumerator WebSocketCoroutine () {
		string uri = addressInputField.text + "/" + channelInputField.text + "?name=" + nameInputField.text;
		statusView.NotConnected ();
		webSocket = new WebSocket(new Uri(uri));
		statusView.Connect ();
		yield return StartCoroutine(webSocket.Connect());

		statusView.Connected ();
		while (true)
		{
			string reply = webSocket.RecvString();
			if (reply != null)
			{
				textAreaView.RecvString (reply);
			}
			if (webSocket.error != null)
			{
				textAreaView.RecvString (reply);
				break;
			}
			yield return new WaitForSeconds(1f);
		}
	}


	public void SendData(string data){
		webSocket.SendString(data);
		textAreaView.SendString(data);
	}

	public void BtnSendData(){
		SendData (messageInputField.text);
	}
}
