using UnityEngine;

public class BrickManager : MonoBehaviour
{
    public GameObject brickPrefab;

    [Min(1)] public int columns = 7;
    [Min(1)] public int rows = 3;
    [Min(0f)] public float spacing = 0.2f;

    private void Start()
    {
        if (brickPrefab == null)
        {
            Debug.LogError("Cal assignar el prefab del brick al BrickManager.", this);
            return;
        }

        SpriteRenderer brickRenderer = brickPrefab.GetComponent<SpriteRenderer>();
        if (brickRenderer == null || brickRenderer.sprite == null)
        {
            Debug.LogError("El prefab del brick ha de tenir un SpriteRenderer amb un sprite.", this);
            return;
        }

        // La mida del brick inclou l'escala del prefab.
        Vector3 brickSize = Vector3.Scale(brickRenderer.sprite.bounds.size, brickPrefab.transform.localScale);
        float stepX = Mathf.Abs(brickSize.x) + Mathf.Max(0f, spacing);
        float stepY = Mathf.Abs(brickSize.y) + Mathf.Max(0f, spacing);

        // Restem la meitat de la distància entre el primer i l'últim brick
        // perquè el centre de la matriu coincideixi amb el BrickManager.
        float startX = -(columns - 1) * stepX / 2f;
        float startY = (rows - 1) * stepY / 2f;

        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                GameObject brick = Instantiate(brickPrefab, transform);
                brick.transform.localPosition = new Vector3(
                    startX + column * stepX,
                    startY - row * stepY,
                    0f);
            }
        }
    }
}
