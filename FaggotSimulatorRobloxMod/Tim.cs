using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Runtime.Versioning;
using System.Text;
using UnityEngine;

namespace FSRMod
{
    public static class Tim
    {
        public static PassiveAbilityTypes Passive => (PassiveAbilityTypes)2823734;
        public static void Add()
        {
            PerformEffectPassiveAbility tim = ScriptableObject.CreateInstance<PerformEffectPassiveAbility>();
            tim._passiveName = "Tim";
            tim._characterDescription = "When swapping with a party member, give this party mmeber and the party member swapped with 1 Bone Spurs.";
            tim._enemyDescription = "When swapping with an enemy, give this enemy and the enemy swapped with 1 Bone Spurs.";
            tim.doesPassiveTriggerInformationPanel = true;
            tim.passiveIcon = ResourceLoader.LoadSprite("Passive_Tim.png");
            tim.type = Passive;
            tim._triggerOn = new TriggerCalls[] { TriggerCalls.OnMoved };
            tim.effects = new EffectInfo[0];
            
            Ability g = new Ability();
            g.name = "Steady Growth";
            g.description = "25% to refresh ability usage. 25% chance to refresh movement.";
            g.cost = new ManaColorSO[] { Pigments.Yellow };
            g.sprite = ResourceLoader.LoadSprite("Ability_Growth.png");
            g.animationTarget = Slots.Self;
            g.visuals = LoadedAssetsHandler.GetEnemyAbility("Wriggle_A").visuals;
            g.effects = new Effect[2];
            g.effects[0] = new Effect(ScriptableObject.CreateInstance<RefreshAbilityUseEffect>(), 1, IntentType.Misc, Slots.Self, Conditions.Chance(25));
            g.effects[1] = new Effect(ScriptableObject.CreateInstance<RestoreSwapUseEffect>(), 1, null, Slots.Self, Conditions.Chance(25));

            Character anthony = new Character();
            anthony.name = "Anthony";
            anthony.entityID = (EntityIDs)2823734;
            anthony.healthColor = Pigments.Red;
            anthony.baseAbility = g;
            anthony.passives = new BasePassiveAbilitySO[] { tim };
            anthony.hurtSound = LoadedAssetsHandler.GetEnemy("TaintedYolk_EN").damageSound;
            anthony.dialogueSound = LoadedAssetsHandler.GetEnemy("TaintedYolk_EN").damageSound;
            anthony.deathSound = LoadedAssetsHandler.GetEnemy("TaintedYolk_EN").deathSound;

            anthony.frontSprite = ResourceLoader.LoadSprite("SmallSpike.png");
            anthony.backSprite = ResourceLoader.LoadSprite("BackSpike.png", 32, new Vector2(0.5f, 0f));
            anthony.overworldSprite = ResourceLoader.LoadSprite("WorldSpike.png", 32, new Vector2(0.5f, 0f));
            anthony.lockedSprite = ResourceLoader.LoadSprite("MenuSpike.png");
            anthony.unlockedSprite = ResourceLoader.LoadSprite("MenuSpike.png");

            Ability c0 = new Ability();
            c0.name = "Tired Consumption";
            c0.description = "Deal 2 damage to this party member.\nConsume 3 Pigment and heal this party member for the amount of Pigment consumed.";
            c0.cost = new ManaColorSO[] { Pigments.SplitPigment(Pigments.Blue, Pigments.Yellow), Pigments.SplitPigment(Pigments.Blue, Pigments.Yellow) };
            c0.sprite = ResourceLoader.LoadSprite("Ability_Consumption.png");
            c0.animationTarget = Slots.Self;
            c0.visuals = LoadedAssetsHandler.GetEnemyAbility("Devour_A").visuals;
            c0.effects = new Effect[3];
            HealEffect exit = ScriptableObject.CreateInstance<HealEffect>();
            exit.usePreviousExitValue = true;
            c0.effects[0] = new Effect(ScriptableObject.CreateInstance<DamageEffect>(), 2, IntentType.Damage_1_2, Slots.Self);
            c0.effects[1] = new Effect(ScriptableObject.CreateInstance<ConsumeRandomManaEffect>(), 3, IntentType.Mana_Consume, Slots.Self);
            c0.effects[2] = new Effect(exit, 1, IntentType.Heal_1_4, Slots.Self);
            Ability c1 = c0.Duplicate();
            c1.name = "Natural Consumption";
            c1.description = "Deal 2 damage to this party member.\nConsume 4 Pigment and heal this party member for the amount of Pigment consumed.";
            c1.effects[1]._entryVariable = 4;
            Ability c2 = c1.Duplicate();
            c2.name = "Fascinating Consumption";
            c2.description = "Deal 2 damage to this party member.\nConsume 6 Pigment and heal this party member for the amount of Pigment consumed.";
            c2.effects[1]._entryVariable = 6;
            c2.effects[2]._intent = IntentType.Heal_5_10;
            Ability c3 = c2.Duplicate();
            c3.name = "Remarkable Consumption";
            c3.description = "Deal 2 damage to this party member.\nConsume 8 Pigment and heal this party member for the amount of Pigment consumed.";
            c3.effects[1]._entryVariable = 8;

            Ability n0 = new Ability();
            n0.name = "Capture the Nutrients";
            n0.description = "Move to the Left or Right twice.\nConsume as much Pigment as possible. If 3 or more Pigment is consumed, trigger the Bone Spurs on the Left and Right party members.";
            n0.cost = new ManaColorSO[] { Pigments.SplitPigment(Pigments.Red, Pigments.Yellow), Pigments.SplitPigment(Pigments.Red, Pigments.Yellow) };
            n0.sprite = ResourceLoader.LoadSprite("Ability_Nutrients.png");
            n0.animationTarget = Slots.Self;
            n0.visuals = null;
            n0.effects = new Effect[6];
            MultipleSwapSidesEffect swapself = ScriptableObject.CreateInstance<MultipleSwapSidesEffect>();
            new CustomIntentInfo("BoneSpurs", (IntentType)2823734, LoadedAssetsHandler.GetCharcater("Fennec_CH").passiveAbilities[0].passiveIcon, IntentType.Misc);
            swapself.Targetting = Slots.Self;
            RemoveStatusEffectEffect noR = ScriptableObject.CreateInstance<RemoveStatusEffectEffect>();
            n0.effects[0] = new Effect(noR, 1, null, Slots.Self, Conditions.Chance(0));
            n0.effects[1] = new Effect(swapself, 2, IntentType.Swap_Sides, Slots.Self);
            n0.effects[2] = new Effect(EZEffects.GetVisuals<AnimationVisualsEffect>("Thorns_1_A", true, Slots.Self), 1, null, Slots.Self);
            n0.effects[3] = new Effect(ScriptableObject.CreateInstance<ConsumeAllManaEffect>(), 1, IntentType.Mana_Consume, Slots.Self);
            n0.effects[4] = new Effect(ScriptableObject.CreateInstance<LastExitMoreOrEqualThanEntryEffect>(), 3, null, Slots.Self);
            n0.effects[5] = new Effect(ScriptableObject.CreateInstance<TriggerBoneSpursEffect>(), 1, CustomIntentIconSystem.GetIntent("BoneSpurs"), Slots.Sides, EZEffects.DidThat<PreviousEffectCondition>(true));
            Ability n1 = n0.Duplicate();
            n1.name = "Steal the Nutrients";
            n1.description = "Remove all Ruptured from this party member and move to the Left or Right twice.\\nConsume as much Pigment as possible. If 3 or more Pigment is consumed, trigger the Bone Spurs on the Left and Right party members.";
            n1.effects[0] = new Effect(noR, 1, IntentType.Rem_Status_Ruptured, Slots.Self);
            Ability n2 = n1.Duplicate();
            n2.name = "Absorb the Nutrients";
            n2.description = "Remove all Ruptured from this party member and move to the Left or Right 3 times.\nConsume as much Pigment as possible. If 3 or more Pigment is consumed, trigger the Bone Spurs on the Left and Right party members.";
            n2.effects[1]._entryVariable = 3;
            Ability n3 = n2.Duplicate();
            n3.name = "Harness the Nutrients";

            Ability d0 = new Ability();
            d0.name = "Awful Decay";
            d0.description = "Apply 1 Constricted to this party member's position and deal 1 damage to them.\nProduce 3 Pigment of random colors.";
            d0.cost = new ManaColorSO[] { Pigments.Yellow };
            d0.sprite = ResourceLoader.LoadSprite("Ability_Decay.png");
            d0.animationTarget = Slots.Self;
            d0.visuals = LoadedAssetsHandler.GetEnemyAbility("Crush_A").visuals;
            d0.effects = new Effect[3];
            GenerateRandomManaBetweenEffect rando = ScriptableObject.CreateInstance<GenerateRandomManaBetweenEffect>();
            rando.possibleMana = new ManaColorSO[] { Pigments.Red, Pigments.Blue, Pigments.Yellow, Pigments.Purple };
            d0.effects[0] = new Effect(ScriptableObject.CreateInstance<ApplyConstrictedSlotEffect>(), 1, IntentType.Field_Constricted, Slots.Self);
            d0.effects[1] = new Effect(ScriptableObject.CreateInstance<DamageEffect>(), 1, IntentType.Damage_1_2, Slots.Self);
            d0.effects[2] = new Effect(rando, 3, IntentType.Mana_Generate, Slots.Self);
            Ability d1 = d0.Duplicate();
            d1.name = "Faltering Decay";
            d1.description = "Apply 1 Constricted to this party member's position and deal 1 damage to them.\nProduce 3 Pigment of random colors, slightly weighted towards Red.";
            GenerateRandomManaBetweenEffect weight = ScriptableObject.CreateInstance<GenerateRandomManaBetweenEffect>();
            weight.possibleMana = new ManaColorSO[] { Pigments.Red, Pigments.Red, Pigments.Red, Pigments.Blue, Pigments.Yellow, Pigments.Purple };
            d1.effects[2]._effect = weight;
            Ability d2 = d1.Duplicate();
            d2.name = "Defensive Decay";
            d2.description = "Apply 1 Constricted to this party member's position and deal 1 damage to them.\nProduce 4 Pigment of random colors, slightly weighted towards Red.";
            d2.effects[2]._entryVariable = 4;
            Ability d3 = d2.Duplicate();
            d3.name = "Strategic Decay";

            anthony.AddLevel(18, new Ability[] { c0, n0, d0 }, 0);
            anthony.AddLevel(20, new Ability[] { c1, n1, d1 }, 1);
            anthony.AddLevel(23, new Ability[] { c2, n2, d2 }, 2);
            anthony.AddLevel(28, new Ability[] { c3, n3, d3 }, 3);
            anthony.AddCharacter();
            LoadedAssetsHandler.GetCharcater("Anthony_CH").characterAnimator = Class1.Assets.LoadAsset<RuntimeAnimatorController>("assets/Fag/FagTall.overrideController");
        }

        public static void IncreaseBoneSpurs(this IUnit self)
        {
            if (self.ContainsPassiveAbility(PassiveAbilityTypes.BoneSpurs))
            {
                self.SetStoredValue(UnitStoredValueNames.BoneSpursPA, self.GetStoredValue(UnitStoredValueNames.BoneSpursPA) + 1);
            }
            else
            {
                self.AddPassiveAbility(Spurs);
            }
        }

        static BasePassiveAbilitySO _spurs;
        public static BasePassiveAbilitySO Spurs
        {
            get
            {
                if (_spurs == null)
                {
                    PerformEffectPassiveAbility ret = ScriptableObject.CreateInstance<PerformEffectPassiveAbility>();
                    ret._passiveName = "Bone Spurs (1)";
                    ret._characterDescription = "On taking direct damage, deal indirect damage to the Opposing enemy for the amount of Bone Spurs this party member has.";
                    ret._enemyDescription = ret._characterDescription;
                    ret._triggerOn = new TriggerCalls[] { TriggerCalls.OnDirectDamaged };
                    ret.doesPassiveTriggerInformationPanel = true;
                    ret.specialStoredValue = UnitStoredValueNames.BoneSpursPA;
                    ret.passiveIcon = LoadedAssetsHandler.GetCharcater("Fennec_CH").passiveAbilities[0].passiveIcon;
                    ret.type = PassiveAbilityTypes.BoneSpurs;
                    DamageByStoredValueEffect spur = ScriptableObject.CreateInstance<DamageByStoredValueEffect>();
                    spur._increaseDamage = true;
                    spur._indirect = true;
                    spur._valueName = UnitStoredValueNames.BoneSpursPA;
                    ret.effects = ExtensionMethods.ToEffectInfoArray(new Effect[]
                    {
                        new Effect(spur, 1, null, Slots.Front)
                    });
                    _spurs = ret;
                }
                return _spurs;
            }
        }
        public static void Combat()
        {
            LoadedAssetsHandler.GetCharcater("Anthony_CH").characterSprite = ResourceLoader.LoadSprite("FrontSpike.png", 32, new Vector2(0.5f, 0f));
        }
        public static void Menu()
        {
            LoadedAssetsHandler.GetCharcater("Anthony_CH").characterSprite = ResourceLoader.LoadSprite("SmallSpike.png");
        }
    }
    public class LastExitMoreOrEqualThanEntryEffect : EffectSO
    {
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = PreviousExitValue;
            return PreviousExitValue >= entryVariable;
        }
    }
    public class TriggerBoneSpursEffect : EffectSO
    {
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            foreach (TargetSlotInfo target in targets)
            {
                if (target.HasUnit)
                {
                    if (target.Unit is IPassiveEffector effector)
                    {
                        foreach (BasePassiveAbilitySO passive in effector.PassiveAbilities)
                        {
                            if (passive.type == PassiveAbilityTypes.BoneSpurs)
                            {
                                CombatManager.Instance.AddUIAction(new ShowPassiveInformationUIAction(effector.ID, effector.IsUnitCharacter, passive.GetPassiveLocData().text, passive.passiveIcon));
                                passive.TriggerPassive(effector, new IntegerReference(0));
                                exitAmount++;
                            }
                        }
                    }
                }
            }
            return exitAmount > 0;
        }
    }
    public class MultipleSwapSidesEffect : SwapToSidesEffect
    {
        public BaseCombatTargettingSO Targetting;
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            int ran = 0;
            for (int i = 0; i < entryVariable; i++)
            {
                if (base.PerformEffect(stats, caster, Targetting != null ? Targetting.GetTargets(stats.combatSlots, caster.SlotID, caster.IsUnitCharacter) : new TargetSlotInfo[0], Targetting != null ? Targetting.AreTargetSlots : false, entryVariable, out int exi))
                {
                    ran++;
                    exitAmount += exi;
                }
            }
            return ran > 0;
        }
    }
}
