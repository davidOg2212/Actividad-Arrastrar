using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{ 
    public GameObject Dual, Presencial, Distancia, Blended, Virtual, DualT, PresencialT, DistanciaT, BlendedT, VirtualT;

    Vector2 DualInitialpos, PresencialInitialpos, DistanciaInitialpos, BlendedInitialpos, VirtualInitialpos;

    void Start()
    {
        DualInitialpos = Dual.transform.position;
        PresencialInitialpos = Presencial.transform.position;
        DistanciaInitialpos = Distancia.transform.position;
        BlendedInitialpos = Blended.transform.position;
        VirtualInitialpos = Virtual.transform.position;
    }

    public AudioSource sourece;
    public AudioClip[] correct;
    public AudioClip incorrect;

    public void DragDual()
    {
        Dual.transform.position = Input.mousePosition;
    }

    public void DragPresencial()
    {
        Presencial.transform.position = Input.mousePosition;
    }

    public void DragDistancia()
    {
        Distancia.transform.position = Input.mousePosition;
    }

    public void DragBlended()
    {
        Blended.transform.position = Input.mousePosition;
    }

    public void DragVirtual()
    {
        Virtual.transform.position = Input.mousePosition;
    }


    public void DropDual()
    {
        float Distance = Vector3.Distance(Dual.transform.position, DualT.transform.position);
        if(Distance<50)
        {
            Dual.transform.position = DualT.transform.position;
            sourece.clip = correct[Random.Range(0, correct.Length)];
            sourece.Play();
        }

        else
        {
            Dual.transform.position = DualInitialpos;
            sourece.clip = incorrect;
            sourece.Play();
        }
    }

    public void DropPresencial()
    {
        float Distance = Vector3.Distance(Presencial.transform.position, PresencialT.transform.position);
        if (Distance < 50)
        {
            Presencial.transform.position = PresencialT.transform.position;
            sourece.clip = correct[Random.Range(0, correct.Length)];
            sourece.Play();
        }

        else
        {
            Presencial.transform.position = PresencialInitialpos;
            sourece.clip = incorrect;
            sourece.Play();
        }
    }

    public void DropDistancia()
    {
        float Distance = Vector3.Distance(Distancia.transform.position, DistanciaT.transform.position);
        if (Distance < 50)
        {
            Distancia.transform.position = DistanciaT.transform.position;
            sourece.clip = correct[Random.Range(0, correct.Length)];
            sourece.Play();
        }

        else
        {
            Distancia.transform.position = DistanciaInitialpos;
            sourece.clip = incorrect;
            sourece.Play();
        }
    }

    public void DropBlended()
    {
        float Distance = Vector3.Distance(Blended.transform.position, BlendedT.transform.position);
        if (Distance < 50)
        {
            Blended.transform.position = BlendedT.transform.position;
            sourece.clip = correct[Random.Range(0, correct.Length)];
            sourece.Play();
        }

        else
        {
            Blended.transform.position = BlendedInitialpos;
            sourece.clip = incorrect;
            sourece.Play();
        }
    }

    public void DropVirtual()
    {
        float Distance = Vector3.Distance(Virtual.transform.position, VirtualT.transform.position);
        if (Distance < 50)
        {
            Virtual.transform.position = VirtualT.transform.position;
            sourece.clip = correct[Random.Range(0, correct.Length)];
            sourece.Play();
        }

        else
        {
            Virtual.transform.position = VirtualInitialpos;
            sourece.clip = incorrect;
            sourece.Play();
        }
    }
}
