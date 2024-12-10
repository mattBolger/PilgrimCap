using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    // Particle systems
    public ParticleSystem cornParticles;
    public ParticleSystem fishParticles;
    //public ParticleSystem turkeyParticles;
    //public ParticleSystem deerParticles;
    //public ParticleSystem potatoeParticles;
    //public ParticleSystem pumpkinParticles;
    //public ParticleSystem hatParticles;
    //public ParticleSystem cranberryParticles;

    // Stand Scripts
    public standCorn corn;
    public standFish fish;
    //public standTurkey turkey;
    //public standDeer deer;
    //public standPotatoes potatoes;
    //public standPumpkin pumpkin;
    //public standHat hat;
    //public standCranberry cranberry;
        

    // Start is called before the first frame update
    void Start()
    {
        cornParticles.gameObject.SetActive(false);
        fishParticles.gameObject.SetActive(false);
        //turkeyParticles.emission.Equals(false);
        //deerParticles.emission.Equals(false);
        //potatoeParticles.emission.Equals(false);
        //pumpkinParticles.emission.Equals(false);
        //hatParticles.emission.Equals(false);
        //cranberryParticles.emission.Equals(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (corn.standBought == true)
        {
            cornParticles.gameObject.SetActive(true);
        }
        if (fish.standBought == true)
        {
            fishParticles.gameObject.SetActive(true);
        }
        //if (turkey.standBought == true)
        //{
        //    turkeyParticles.emission.Equals(true);
        //}
        //if (deer.standBought == true)
        //{
        //    deerParticles.emission.Equals(true);
        //}
        //if (potatoes.standBought == true)
        //{
        //    potatoeParticles.emission.Equals (true);
        //}
        //if (pumpkin.standBought == true)
        //{
        //    pumpkinParticles.emission.Equals(true);
        //}
        //if (hat.standBought == true)
        //{
        //    hatParticles.emission.Equals(true);
        //}
        //if (cranberry.standBought == true)
        //{
        //    cranberryParticles.emission.Equals(true);
        //}
    }
}
