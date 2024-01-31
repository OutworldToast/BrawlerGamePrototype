using Models;

namespace Editors;

public class BasicEnemyEditor : EntityEditor {
    public BasicEnemyEditor(Options? options) : base(options) {}

    public override IEntity CreateEnemy() {
        return new BasicEnemy();
    }
}