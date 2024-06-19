using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Services.Lobbies.Models;
using UnityEngine;

public class CampaignItem : MonoBehaviour
{
    [SerializeField] private TMP_Text campaignNameText;
    [SerializeField] private TMP_Text lastModifiedText;

    public void Initialize(Campaign campaign)
    {
        campaignNameText.text = campaign.CampaignName;
        lastModifiedText.text = campaign.LastModified;
    }

}
