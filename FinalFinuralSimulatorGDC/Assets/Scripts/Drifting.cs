using UnityEngine;
using System.Collections;

public class Drifting : MonoBehaviour
{

    [SerializeField]
    WheelCollider DriftWheel1;

    [SerializeField]
    WheelCollider DriftWheel2;

    [SerializeField]
    WheelCollider DriftWheel3;

    [SerializeField]
    WheelCollider DriftWheel4;


    [SerializeField]
    WheelCollider StandartWheel;

    [SerializeField]
    WheelFrictionCurve WheeltoDrift;

    [SerializeField]
    TrailRenderer DriftSkirt1;

    [SerializeField]
    TrailRenderer DriftSkirt2;


    WheelFrictionCurve WheeltoNormal;

    [SerializeField]
    float DriftStiffness = 0.5f;

    [SerializeField]
    Transform backWeelRPosition;


    [SerializeField]
    float NormanlFriction = 1f;

    public bool isDrifting = false;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    {
        Ice ice = GameObject.Find("IceTrigger").GetComponent<Ice>();


        // stabaliseVriction();

        if (ice.isOnice==false)
        {
            DriftWheel1.sidewaysFriction = StandartWheel.sidewaysFriction;
            DriftWheel2.sidewaysFriction = StandartWheel.sidewaysFriction;
            DriftWheel3.sidewaysFriction = StandartWheel.sidewaysFriction;
            DriftWheel4.sidewaysFriction = StandartWheel.sidewaysFriction;
        }

        if (Input.GetButton("Drift"))
        {

            ice.isOnice = true;

            WheeltoDrift.stiffness = DriftStiffness * Time.deltaTime;


            DriftWheel1.sidewaysFriction = WheeltoDrift;
            DriftWheel2.sidewaysFriction = WheeltoDrift;


            //DriftSkirt1.transform.position = Vector3.MoveTowards(transform.position, backWeelRPosition.position,0);

        }
    

        //else {
        //    DriftSkirt1.time = 0.25f;
        //       }

        if (Input.GetKeyUp("space"))
            ice.isOnice = false;





    }

    void stabaliseVriction()
    {
        WheeltoNormal.stiffness = NormanlFriction;

        DriftWheel1.sidewaysFriction = WheeltoNormal;
        DriftWheel2.sidewaysFriction = WheeltoNormal;
        print("not drifting");
    }


    public void Drift()
    {
        Ice ice = GameObject.Find("IceTrigger").GetComponent<Ice>();

        ice.isOnice = true;

        WheeltoDrift.stiffness = DriftStiffness * Time.deltaTime;


        DriftWheel1.sidewaysFriction = WheeltoDrift;
        DriftWheel2.sidewaysFriction = WheeltoDrift;
    }

    public void notDrift()
    {
        Ice ice = GameObject.Find("IceTrigger").GetComponent<Ice>();

        ice.isOnice = false;
    }

}

