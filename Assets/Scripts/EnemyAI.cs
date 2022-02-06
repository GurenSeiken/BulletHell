using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    [SerializeField] private float lowHealthThreshold;
    [SerializeField] private float healthRestoreRate;

    [SerializeField] private float chasingRange;
    [SerializeField] private float shootingRange;

    [SerializeField] public Transform playerTransform;

    private Material material;
    private Node topNode;
    private NavMeshAgent agent;

    private float _currentHealth;
    public float currentHealth{
        get{return _currentHealth;}
        set{_currentHealth = Mathf.Clamp(value, 0, startingHealth);}
    }

    private void Awake() {
        agent = GetComponent<NavMeshAgent>();
        material = GetComponent<MeshRenderer>().material;
    }

    private void Start() {
        _currentHealth = startingHealth;
        ConstructBehaviourTree();
    }

    private void ConstructBehaviourTree(){
        HealthNode healthNode = new HealthNode(this, lowHealthThreshold);
        ChaseNode chaseNode = new ChaseNode(playerTransform, agent, this);
        RangeNode chasingRangeNode = new RangeNode(chasingRange, playerTransform, transform);
        RangeNode shootingRangeNode = new RangeNode(shootingRange, playerTransform, transform);
        ShootNode shootNode = new ShootNode(agent, this);

        Sequence chaseSequence = new Sequence(new List<Node> {chasingRangeNode, chaseNode});
        Sequence shootSequence = new Sequence(new List<Node> {shootingRangeNode, shootNode});

        topNode = new Selector(new List<Node> {shootSequence, chaseSequence});
    }

    private void Update() {
        topNode.Evaluate();
        if(topNode.nodeState == NodeState.FAILURE){
            SetColor(Color.red);
        }
        if (playerTransform.position.z >= transform.position.z)
        {
            Debug.Log("Hey");
            Destroy(gameObject);
        }
        currentHealth += Time.deltaTime * healthRestoreRate;
    }

    private void OnMouseDown() {
        currentHealth -= 10f;
    }

    public void SetColor(Color color){
        material.color = color;
    }
}
