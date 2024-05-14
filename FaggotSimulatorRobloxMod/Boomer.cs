using System;
using System.Collections.Generic;
using System.Text;
using BrutalAPI;
using UnityEngine;

namespace FSRMod
{
    public static class Boomer
    {
        public static void Add()
        {
            PerformEffectPassiveAbility presence = ScriptableObject.CreateInstance<PerformEffectPassiveAbility>();
            presence._passiveName = "Presence";
            presence.passiveIcon = ResourceLoader.LoadSprite("Passive_Presence.png");
            presence._enemyDescription = "On a party member moving in front of this enemy, force them to perform a random ability.";
            presence._characterDescription = "On an enemy moving in front of this party member... actually i think the effect doesnt work in base game oh well";
            presence.type = (PassiveAbilityTypes)887207;
            presence._triggerOn = new TriggerCalls[] { (TriggerCalls)AmbushManager.Patiently };
            presence.doesPassiveTriggerInformationPanel = true;
            presence.conditions = Passives.Slippery.conditions;
            presence.effects = ExtensionMethods.ToEffectInfoArray(new Effect[]
            {
                new Effect(ScriptableObject.CreateInstance<PerformRandomAbilityEffect>(), 1, null, Slots.Front)
            });
            PerformEffectPassiveAbility explode = ScriptableObject.CreateInstance<PerformEffectPassiveAbility>();
            explode._passiveName = "Explosive";
            explode.passiveIcon = ResourceLoader.LoadSprite("Passive_Explosive.png");
            explode._enemyDescription = "On death, instantly kill the Opposing party member.";
            explode._characterDescription = " blah blahbl";
            explode.type = (PassiveAbilityTypes)887208;
            explode._triggerOn = new TriggerCalls[] { TriggerCalls.OnDeath };
            explode.doesPassiveTriggerInformationPanel = true;
            explode.conditions = new EffectorConditionSO[0];
            explode.effects = ExtensionMethods.ToEffectInfoArray(new Effect[]
            {
                new Effect(ScriptableObject.CreateInstance<DirectDeathEffect>(), 1, null, Slots.Front)
            });

            Enemy boomer = new Enemy()
            {
                name = "Boomer",
                health = 16,
                entityID = (EntityIDs)82820072,
                healthColor = Pigments.Purple,
                passives = new BasePassiveAbilitySO[] { Passives.Leaky, presence, explode },
                prefab = Class1.Assets.LoadAsset<GameObject>("assets/Roblos/Roblox_Enemy.prefab").AddComponent<MultiSpriteEnemyLayout>(),
                combatSprite = ResourceLoader.LoadSprite("BoomerIcon.png"),
                overworldAliveSprite = ResourceLoader.LoadSprite("BoomerWorld.png"),
                overworldDeadSprite = ResourceLoader.LoadSprite("BoomerDead.png"),
                hurtSound = LoadedAssetsHandler.LoadCharacter("Gospel_CH").damageSound,
                deathSound = "event:/Mungeater/Enemy/BoomerDeath",
            };
            boomer.prefab._gibs = Class1.Assets.LoadAsset<GameObject>("assets/Roblos/Slop_Gibs.prefab").GetComponent<ParticleSystem>();
            boomer.prefab.SetDefaultParams();
            (boomer.prefab as MultiSpriteEnemyLayout).OtherRenderers = new SpriteRenderer[]
            {
                boomer.prefab._locator.transform.Find("Sprite").Find("B1").GetComponent<SpriteRenderer>(),
                boomer.prefab._locator.transform.Find("Sprite").Find("B2").GetComponent<SpriteRenderer>(),
                boomer.prefab._locator.transform.Find("Sprite").Find("B3").GetComponent<SpriteRenderer>(),
            };
            Ability move = new Ability();
            move.name = "Instability";
            move.description = "Move all party members closer to this enemy.";
            move.sprite = ResourceLoader.LoadSprite("Ability_Instability.png");
            move.rarity = 5;
            move.animationTarget = Slots.Self;
            move.visuals = LoadedAssetsHandler.GetEnemyAbility("Wriggle_A").visuals;
            move.effects = new Effect[2];
            SwapToOneSideEffect left = ScriptableObject.CreateInstance<SwapToOneSideEffect>();
            left._swapRight = false;
            SwapToOneSideEffect right = ScriptableObject.CreateInstance<SwapToOneSideEffect>();
            right._swapRight = true;
            move.effects[0] = new Effect(right, 1, IntentType.Swap_Right, Slots.SlotTarget(new int[] { -1, -2, -3, -4 }, false));
            move.effects[1] = new Effect(left, 1, IntentType.Swap_Left, Slots.SlotTarget(new int[] { 1, 2, 3, 4 }, false));
            boomer.abilities = new Ability[] { move };
            boomer.AddEnemy();
        }
    }
}
