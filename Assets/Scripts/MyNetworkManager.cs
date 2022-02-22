using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class MyNetworkManager : NetworkManager
{
    public override void OnStartServer()
    {
        print("Server started");
    }
    public override void OnStopServer()
    {
        print("Server stopped");
    }
    public override void OnClientConnect(NetworkConnection conn)
    {
        print("Connected to Server!");
    }
    public override void OnClientDisconnect(NetworkConnection conn)
    {
        print("Disconnected from server!");
    }
}
