using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Services.Lobbies.Models;
using TMPro;
using Unity.Services.Lobbies;

public class LobbyItem : MonoBehaviour
{
   [SerializeField] private TMP_Text LobbyNameText;
   [SerializeField] private TMP_Text lobbyPlayerText;

   private LobbyList lobbyList;
   private Lobby lobby;

   public void initalise(LobbyList lobbyList, Lobby lobby)
   {
      this.lobbyList = lobbyList;
      this.lobby = lobby;
      LobbyNameText.text = lobby.Name;
      lobbyPlayerText.text = $"{lobby.Players.Count}/ {lobby.MaxPlayers}";
   }

   public void Join()
   {
      lobbyList.JoinAsync(lobby);
   }
}
