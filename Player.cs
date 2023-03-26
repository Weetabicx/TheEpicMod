using Terraria;
using Terraria.ModLoader;
using Terraria.DataStructures;

namespace TheEpicMod.Player

{
    public class TheEpicModPlayer : ModPlayer

    {
        // Overrides the virtual fucntion returns nothing and takes 4 arguments when called
        public override void Kill(double damage, int hitDirection, bool pvp, PlayerDeathReason damageSource)
        {   
            Main.NewText($"{damage} {hitDirection} {pvp} {damageSource}");

            // These health changes are completely temporary
            Player.statLife += 1000;
            Player.statLifeMax += 1000; // Can't increase max health past default of 500
            Player.statLifeMax2 += 1000; // Seems to do the same thing?
        }

        public override void OnHitByNPC(NPC npc, int damage, bool crit) {
            Player.Heal((int) damage);
            Main.NewText($"Weeved! Healed {(int) damage}! Dumbass {npc.FullName}");
            Player.dazed = true;
        }
        public override void Hurt(bool pvp, bool quiet, double damage, int hitDirection, bool crit, int cooldownCounter) {
        }
        
    }
}