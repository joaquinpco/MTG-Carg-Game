﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace AkeenDev
{
    public class CardViz : MonoBehaviour
    {
        public Text title;
        public Text detail;
        public Text flavor;
        public Text Artist;
        public Image art;

        //Instance of One Card Model
        public Card card;

        public void LoadCard(Card  c)
        {
            if (c != null)
            {
                card = c;

                title.text = card.title;
                detail.text = card.detail;
                flavor.text = card.flavor;
                Artist.text = card.artist;
            }
        }

        // Use this for initialization
        void Start()
        {
            LoadCard(card);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}