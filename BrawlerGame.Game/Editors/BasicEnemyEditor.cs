using Models;

namespace Editors;

public class BasicEnemyEditor : EntityEditor {
    public BasicEnemyEditor(IOptions? options) : base(options) {}

    public override IEntity CreateEnemy() {
        return new BasicEnemy();
    }
}