using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ParticleManager : MonoBehaviour
{
    // Particle systems
    public ParticleSystem cornParticles;
    public ParticleSystem fishParticles;
    public ParticleSystem turkeyParticles;
    public ParticleSystem deerParticles;
    public ParticleSystem potatoeParticles;
    public ParticleSystem pumpkinParticles;
    public ParticleSystem hatParticles;
    public ParticleSystem cranberryParticles;

    // Stand Scripts
    public standCorn corn;
    public standFish fish;
    public standTurkey turkey;
    public standDeer deer;
    public standPotatoes potatoes;
    public standPumpkin pumpkin;
    public standHat hat;
    public standCranberry cranberry;


    // Start is called before the first frame update
    void Start()
    {
        cornParticles.gameObject.SetActive(false);
        fishParticles.gameObject.SetActive(false);
        turkeyParticles.gameObject.SetActive(false);
        deerParticles.gameObject.SetActive(false);
        potatoeParticles.gameObject.SetActive(false);
        pumpkinParticles.gameObject.SetActive(false);
        hatParticles.gameObject.SetActive(false);
        cranberryParticles.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        ActivateParticles();
        //UpdateParticles();
    }

    public void UpdateCornParticles()
    {
        // Stop the particles
        cornParticles.Stop();

        // Alter the values
        var cornPartRate = cornParticles.emission;
        cornPartRate.rateOverTime = corn.standLevel / 10f;

        // Play the particles
        cornParticles.Play();
        
    }

    public void UpdateFishParticles()
    {
        fishParticles.Stop();

        var fishPartRate = fishParticles.emission;
        fishPartRate.rateOverTime = fish.standLevel / 10f;

        fishParticles.Play();
    }

    public void UpdateTurkeyParticles()
    {
        turkeyParticles.Stop();

        var turkeyPartRate = turkeyParticles.emission;
        turkeyPartRate.rateOverTime = turkey.standLevel / 10f;

        fishParticles.Play();
    }

    public void UpdateDeerParticles()
    {
        deerParticles.Stop();

        var deerPartRate = deerParticles.emission;
        deerPartRate.rateOverTime = deer.standLevel / 10f;

        deerParticles.Play();
    }

    public void UpdatePotatoeParticles()
    {
        potatoeParticles.Stop();

        var potatoePartRate = potatoeParticles.emission;
        potatoePartRate.rateOverTime = potatoes.standLevel / 10f;

        potatoeParticles.Play();
    }

    public void UpdatePumpkinParticles()
    {
        pumpkinParticles.Stop();

        var pumpkinPartRate = pumpkinParticles.emission;
        pumpkinPartRate.rateOverTime = pumpkin.standLevel / 10f;

        pumpkinParticles.Play();
    }

    public void UpdateHatParticles()
    {
        hatParticles.Stop();

        var hatPartRate = hatParticles.emission;
        hatPartRate.rateOverTime = hat.standLevel / 10f;

        hatParticles.Play();
    }

    public void UpdateCranberryParticles()
    {
        cranberryParticles.Stop();

        var cranberryPartRate = cranberryParticles.emission;
        cranberryPartRate.rateOverTime = cranberry.standLevel / 10f;

        cranberryParticles.Play();
    }

    void ActivateParticles()
    {
        if (corn.standBought == true)
        {
            cornParticles.gameObject.SetActive(true);
        }
        if (fish.standBought == true)
        {
            fishParticles.gameObject.SetActive(true);
        }
        if (turkey.standBought == true)
        {
            turkeyParticles.gameObject.SetActive(true);
        }
        if (deer.standBought == true)
        {
            deerParticles.gameObject.SetActive(true);
        }
        if (potatoes.standBought == true)
        {
            potatoeParticles.gameObject.SetActive(true);
        }
        if (pumpkin.standBought == true)
        {
            pumpkinParticles.gameObject.SetActive(true);
        }
        if (hat.standBought == true)
        {
            hatParticles.gameObject.SetActive(true);
        }
        if (cranberry.standBought == true)
        {
            cranberryParticles.gameObject.SetActive(true);
        }
    }
}
