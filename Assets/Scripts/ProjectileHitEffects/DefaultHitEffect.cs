using Creatures;
using Projectiles;
using UnityEngine;

namespace ProjectileHitEffects
{
	public class DefaultHitEffect : ProjectileHitEffect
	{
		public override void Initiate(GameObject target, Shell shell)
		{
			var targetCreature = target.GetComponent<Creature>();
			if (targetCreature != null)
			{
				print("hit effect");
				targetCreature.TakeDamage(shell.damage);
			}
		}
	}
}