using UnityEngine;

public class InvaderGrid : MonoBehaviour
{
    public Invader[] prefabs;
    public int rows = 5;
    public int cols = 11;

    public int spaceBetween;

    private void Awake() {

        for (int row = 0; row < this.rows; row++) {

            float width = spaceBetween * (this.cols - 1);
            float height = spaceBetween * (this.rows - 1);

            Vector2 centering = new Vector2(-width / 2, -height / 2);

            Vector3 rowPosition = new Vector3(centering.x, centering.y + (row * spaceBetween), 0);

            for (int col = 0; col < cols; col++) {

                Invader invader = Instantiate(this.prefabs[row], this.transform);

                Vector3 position = rowPosition;

                position.x += col * spaceBetween;

                invader.transform.localPosition = position;
            }
        }
    }

}
