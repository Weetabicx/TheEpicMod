using Terraria;
using Terraria.ModLoader;
using Terraria.DataStructures;

namespace TheEpicMod.Player

{
    public class TheEpicModPlayer : ModPlayer

    {
        public override void SetStaticDefaults()
        {
            // Player.maxRunSpeed = 300;
            Player.accRunSpeed = 300;
            Player.runAcceleration = 300;
        }
        int cut = 0;
        // Overrides the virtual fucntion returns nothing and takes 4 arguments when called
        public override void Kill(double damage, int hitDirection, bool pvp, PlayerDeathReason damageSource)
        {   
            Main.NewText($"{damage} {hitDirection} {pvp} {damageSource}");
            
            Player.statLifeMax += 10000;
        }

        public override void OnHitByNPC(NPC npc, int damage, bool crit) {

        }
        // public override void Hurt(bool pvp, bool quiet, double damage, int hitDirection, bool crit, int cooldownCounter) {
        //     if (cut % 3 == 0) {
        //         cut ++;
        //         Hurt(pvp, quiet, (2000), hitDirection, crit, cooldownCounter);
        //     } else {
        //         cut ++;
        //     }
        // }   

        
    }
}