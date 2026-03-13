using UnityEngine;
using System.Collections.Generic;

public class ParticleController : MonoBehaviour
{
    
    public GameObject particlePrefab;

    
    public int numberOfParticles = 20;
    public float initialVelocity = 10f;
    public float initialAngle = 45f;
    public float lifetime = 5f;
    public float gravity = 9.8f;

    private List<SimpleParticle> particles = new List<SimpleParticle>();

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CreateParticleExplosion();
        }

        UpdateParticleExplosion();
    }

    
    void CreateParticleExplosion()
    {
        if (particlePrefab == null)
        {
            return;
        }

        for (int i = 0; i < numberOfParticles; i++)
        {
            GameObject obj = Instantiate(particlePrefab,transform.position,Quaternion.identity);

            
            if (obj.scene.rootCount == 0)
            {
                Destroy(obj);
                continue;
            }

            SimpleParticle part = obj.GetComponent<SimpleParticle>();

            if (part == null)
            {
                Destroy(obj);
                continue;
            }

            part.initialVelocity = Random.Range(initialVelocity * 0.8f, initialVelocity * 1.2f);

            part.initialAngle = initialAngle + Random.Range(-10f, 10f);

            part.maxLifetime = Random.Range(lifetime * 0.8f, lifetime * 1.2f);

            part.gravity = gravity;
            part.initialPosition = obj.transform.position;
            part.currentLifetime = 0f;

            particles.Add(part);
        }
    }

    
    void UpdateParticleExplosion()
    {
        for (int i = particles.Count - 1; i >= 0; i--)
        {
            SimpleParticle part = particles[i];

            if (part == null)
            {
                particles.RemoveAt(i);
                continue;
            }

            UpdateParticlePosition(part);

            if (part.currentLifetime > part.maxLifetime)
            {
                Destroy(part.gameObject);
                particles.RemoveAt(i);
            }
        }
    }

    
    void UpdateParticlePosition(SimpleParticle part)
    {
        part.currentLifetime += Time.deltaTime;

        float angleRad = part.initialAngle * Mathf.Deg2Rad;

        float vx = part.initialVelocity * Mathf.Cos(angleRad);
        float vy = part.initialVelocity * Mathf.Sin(angleRad);

        float x = vx * part.currentLifetime;
        float y = vy * part.currentLifetime - 0.5f * part.gravity * part.currentLifetime * part.currentLifetime;

        Vector3 newPosition = part.initialPosition + new Vector3(x, y, 0f);

        part.transform.position = newPosition;
    }
}