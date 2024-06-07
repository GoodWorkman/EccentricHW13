using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Collector : MonoBehaviour
{
    [SerializeField] private float _distanceToCollect;
    [SerializeField] private LayerMask _layerMask;

    [SerializeField] private ExperienceManager _experienceManager;

    private void FixedUpdate()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, _distanceToCollect, _layerMask,
            QueryTriggerInteraction.Ignore);

        foreach (Collider collider in colliders)
        {
            if (collider.GetComponentInParent<Loot>() is Loot loot)
            {
                loot.Collect(this);
            }
        }
    }

    public void TakeExperience(int lootValue)
    {
        _experienceManager.AddExperience(lootValue);
    }

#if UNITY_EDITOR
     private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, _distanceToCollect);
    }
#endif
}