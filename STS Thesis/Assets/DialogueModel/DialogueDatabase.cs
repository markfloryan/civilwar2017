using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.DialogueModel
{
    class DialogueDatabase
    {
        private Dialogue[] _reporterDialogue;
        private Dialogue[] _graveDialogue;
        private Dialogue[] _soldierDialogue;
        private Dialogue[] _abolitionistDialogue;
        private Dialogue[] _newspaperDialogue;
        private Dialogue _meadeDialogue;
        private Dialogue _douglassDialogue;
        private Dialogue _lincolnDialogue;

        public DialogueDatabase()
        {
            Dialogue r1 = new Dialogue(new String[] {
                "I'm not too knowledgeable of important figures...do you mind helping?%Yes|Not now",
                "Okay! Thank you!|That's fine.",
                "Yes...the first one is the Confederate General during this battle.|#END",
                "Who is he again?%Meade|Lee|Grant|Jackson",
                "No! I'm pretty sure that's our general!|Yes! Okay...Robert...E...Lee...got it!|No, that's one of our generals!|No, that general didn't fight in this battle!",
                "#END|Okay, just need one more...|#END|#END",
                "Who was our general during the battle?%Meade|Lee|Grant|Jackson",
                "Yes! Of course! How could I forget!|No! You just told me that was the Confederate General!|No...I don't think so...|No...I don't think so...",
                "Thank you so much for the help!|#END|#END|#END",
                "#naval1" });

            Dialogue r2 = new Dialogue(new String[]
            {
"I'm suppose to be writing about the timeline of events! Do you have any information?%Yes|Not Now",
      "Excellent! Okay, let me get my paper out|Sorry to bother you!",
      "Got it. Alright then...|#END",
      "What month did this battle take place again?%May|June|July|August",
      "That's not what I've been hearing from other sources...are you sure?|That's not what I've been hearing from other sources...are you sure?|Ah,  yes! That's right! Thanks!|That's not what I've been hearing from other sources...are you sure?",
      "#END|#END|Yes, yes. All good...Just need to write the year here on this report|#END",
      "Umm...oh, I'm drawing a blank.",
      "What year is it again?%1861|1862|1863|1864",
      "No, that's not right. That's when the war started.|No, that was last year.|Oh yes! Silly me! It's 1863!|No, that's next year!",
      "#END|#END|Thanks for all the help!|#END",
      "#naval2"
            });

            Dialogue r3 = new Dialogue(new String[]
            {
                "I'm from New York and fell asleep on the train getting here.",
      "I've been too embarrassed to ask what state we're in, but I need it for the article...",
      "Can you help?%Pennsylvania|Virginia|Maryland|North Carolina",
      "Yes! That rings a bell! Thank you!|No...that does not sound right...|No...that does not sound right...|No...that does not sound right...",
      "Now I won't be so embarrassed!|#END|#END|#END",
      "#naval3"
            });

            Dialogue r4 = new Dialogue(new String[]
            {
                "I've heard that ANTIETAM has had the most casualties of any battle so far this war.%Yes|No",
      "Guess it has then!|Oh? Do you know of a battle that has had more?",
      "Which one?%Bull Run|Fort Sumter|    Gettysburg|Vicksburg",
      "I don't think so...|I don't think so...|Really? This one?|I don't think so...",
      "#END|#END|I'll need a number for the report though|#END",
      "Do you have an estimate?%10,000|20,000|50,000|1,000,000",
      "If it was only that much, then it can't be!|If it was only that much, then it can't be!|That many? Unbelievable.|I can't believe that! That is just too many soldiers!",
      "#END|#END|Thank you for the information!|#END",
      "#naval4"
            });

            Dialogue r5 = new Dialogue(new String[]
            {
                "I keep hearing soldiers talk about some Confederate General CHARGING CEMETERY HILL on the last day.",
      "I can't remember the name though...%Lee|Jackson|Grant|Pickett",
      "No...that's not it...close though|No, that general wasn't even there...|No! That's one of our generals!|YES! PICKETT!",
      "#END|#END|#END|PICKETT'S CHARGE! I feel like people will remember that for a long time!",
      "#naval5"
            });

            Dialogue g1 = new Dialogue(new String[] {
                "Robert Robertson (1843-1863): Died defending CEMETERY HILL during PICKETT'S CHARGE."
            });
            Dialogue g2 = new Dialogue(new String[] {
                "Garth Hudson (1847-1863): Died defending CEMETERY HILL during PICKETT'S CHARGE."
            });
            Dialogue g3 = new Dialogue(new String[] {
                "Frederick Carter (1842-1863): Died during the battle inside of the town of Gettysburg."
            });
            Dialogue g4 = new Dialogue(new String[] {
                "James Weider (1838-1863): Died during the skirmish at Devil's Den and the Peach Orchard."
            });
            Dialogue g5 = new Dialogue(new String[] {
                "Randal Ciarlante (1843-1863): Died during the skirmish at Devil's Den and the Peach Orchard."
            });
            Dialogue g6 = new Dialogue(new String[] {
                "Richard Danko (1844-1863): Died defending CEMETERY HILL during PICKETT'S CHARGE."
            });

            Dialogue s1 = new Dialogue(new String[]
            {
                "I was wounded on that Wednesday, before any real fighting began.",
      "We had arrived before GENERAL MEADE did so we were outnumbered.",
      "We couldn't fight so we retreated through the town hoping to regroup."
            });
            Dialogue s2 = new Dialogue(new String[]
            {
                "I arrived with GENERAL MEADE in the middle of the night Thursday.",
      "We arrived at CEMETARY HILL and saw some wounded soldiers already.",
      "Those who had fought and then fled through the town.",
      "We began to fortify our position on that HILL and prepare for battle!"
            });
            Dialogue s3 = new Dialogue(new String[]
            {
                "Most of my fellow soldiers fell on that Thursday.",
      "Devil's Den, Peach Orchard, Little Round Top...",
      "Some of the most intense battles I have ever seen happened around that HILL",
      "And yet, the battle was not even close to over..."
            });
            Dialogue s4 = new Dialogue(new String[]
            {
                "I thought I was dreaming.",
      "After all of the carnage on that Thursday I couldn't believe it.",
      "Friday, 15,000 men charging at our line led by GENERAL PICKETT",
      "I thought that we were done for..."
            });
            Dialogue s5 = new Dialogue(new String[]
            {
                 "We held that hill against all odds.",
      "Even with PICKETT and his men CHARGING at us, we held.",
      "And we hit their advance back until LEE and his men finally retreated.",
      "After three days of fighting, we had finally won."
            });
            Dialogue s6 = new Dialogue(new String[]
            {
                "It's nice that you were able to come up here to PENNYSYLVANIA for the service today.",
      "Soldiers from all over the UNION and CONFEDERACY came and fought here during this battle.",
      "Maybe even someone from your own town!"
            });
            Dialogue s7 = new Dialogue(new String[]
            {
                 "I can only imagine what this place would have looked like last JULY.",
      "The summer sun rising to see brothers facing each other, ready to fight..."
            });
            Dialogue s8 = new Dialogue(new String[]
            {
                 "I am a Virginian, so I knew of ROBERT E. LEE long before the war.",
      "But having to fight LEE? Alongside MEADE and others? That was something...",
      "I wish for this war to end soon...there is too much bloodshed between brothers.."
            });
            Dialogue s9 = new Dialogue(new String[]
            {
                 "I have heard from the top that this battle had more casualties than any other before it.",
      "An estimated 50,000 men on both sides...",
      "I hope that this battle will be the DEADLIEST and that no further one will surpass it..."
            });
            Dialogue s10 = new Dialogue(new String[]
            {
                "I was with my friend from school, Garth, while defending CEMETERY HILL.",
      "When GENERAL PICKETT CHARGED with his men, well...Garth didn't survive...",
      "I believe his grave is up North if you'd like to pay your respects..."
            });

            Dialogue a1 = new Dialogue(new String[]
            {
                "I was a slave in the SOUTH when I got word of the EMANCIPATION PROCLAMATION",
      "I then decided it was time to escape North and claim my freedom!",
      "I now do all I can to help others gain the freedom they deserve!"
            });

            Dialogue a2 = new Dialogue(new String[]
            {
                 "Frederick Douglass has been an incredible mentor to me.",
      "He's even given me one of his books: Uncle Tom's Cabin!",
      "Being an escaped slave, I can really relate to the story!"
            });

            Dialogue a3 = new Dialogue(new String[]
            {
                "The EMANCIPATION PROCLAMATION is a good step forward, but it is not enough.",
      "It only frees the slaves in the Confederacy, when there are still unfree people in the North!",
      "I will continue to fight as an ABOLITIONIST until this is fixed!"
            });

            Dialogue a4 = new Dialogue(new String[]
            {
                "I am one of the writers for The Liberator! That means Frederick Douglass is my boss!",
      "I left a lot of old copies of our NEWSPAPERS around today for people to pick up if need be.",
      "You're welcome to read too if you like!"
            });

            Dialogue n1 = new Dialogue(new String[]
            {
                "EMANCIPATION PROCLAMATION ENACTED",
      "Jan, 1863, LINCOLN uses EXECUTIVE ORDER to free all SLAVES in CONFEDERACY.",
      "Union now officially recognizes 3 million slaves as FREE.",
      "While this does not apply to all slaves (such as those still in Union) this is still great progress!",
      "#paper1()"
            });

            Dialogue n2 = new Dialogue(new String[]
            {
                "TROOPS COVERGE ON GETTYSBURG",
      "Witnesses report Confederate Troops led by ROBERT E. LEE are amassing towards GETTYSBURG.",
      "Reports say that fighting with UNION troops led by GENERAL MEADE will begin.",
      "Civilians are urged to find safety and shelter and remain inside.",
      "#paper2()"
            });

            Dialogue n3 = new Dialogue(new String[]
            {
                "GETTYSBURG GOES TO UNION",
      "After three days of fighting, GENERAL LEE has retreated while the UNION forces remain!",
      "Already, reports are calling this a DECISIVE battle, one that will surely turn the tide of this war!",
      "PRESIDENT LINCOLN is also preparing to visit the battle site and the planned cemetery later this year.",
      "#paper3()"
            });

            _meadeDialogue = new Dialogue(new String[]
            {
                "Are you hear to get my account of the battle?%Yes|No",
      "Excellent! Let's see, where to begin...|Oh, okay then. Let me know if things change.",
      "Let's see...|#END",
      "Where should I actually begin?%'Meade Arrives'|'Pickett's Charge'|'Town'|'Hill'|'Retreat'",
      "No, That doesn't sound right...try talking to some of the soldiers to refresh my memory!|No, that doesn't seem right...try talking to some of the soldiers to refresh my memory!|Ah, yes! The fighting in the TOWN!|No, that doesn't sound right...try talking to some of the soldiers to refresh my memory!|No, that doesn't sound right...try talking to some of the soldiers to refresh my memory!",
      "#END|#END|Yes, the first group of soldiers arrived in the TOWN and were outmatched by LEE and his men.|#END|#END",
      "They ran retreating through the TOWN OF GETTYSBURG and then-",
      "And then...ummm...",
      "Oh this is embarrassing, what happened next again?%'Meade Arrives'|'Pickett's Charge'|'Town'|'Hill'|'Retreat'",
      "Oh! Of course! The men and I rendezvous together and reinforce our position!|No, That doesn't sound right...try talking to some of the soldiers to refresh my memory!|No, that doesn't seem right...try talking to some of the soldiers to refresh my memory!|No, that doesn't sound right...try talking to some of the soldiers to refresh my memory!|No, that doesn't sound right...try talking to some of the soldiers to refresh my memory!",
      "And then the day came, Thursday, and we fought and fought from our fortified position!|#END|#END|#END|#END|",
      "And most of the battle took place...umm...",
      "My memory is fading again...Most of the battle took place on the day...?%'In the Town'|'On the Hill'",
      "No, that's where most of battle took place the day before...hmm...|Yes! Yes! On CEMETERY HILL!",
      "#END|Yes, we held there the entire day. Come morning, LEE had only one more option left!",
      "And he took it because he had to! So on Friday, he decided to-",
      "He decided...oh goodness. What did he do again?%'Retreat'|'Call Reinforcements'|'Charge the Hill'",
      "No...not quite that soon...|No, there were no reinforcements to call...|YES! PICKETT'S FAMOUS CHARGE!",
      "#END|#END|Thousands and thousands of men led by GENERAL PICKETT come and charge CEMETERY HILL!",
      "But we fought them all off and then...and then...oh, not again...%'Lee Retreats'|'Meade Retreats'|'More Town Fighting'",
      "YES! He and his men finally retreated!|Oh come now! We wouldn't be standing here if we retreated!|No, the fighting was done shortly after that...",
      "And with that, we were able to stop a Confederate invasion of the North!|#END|#END",
      "I home my account was helpful for the President (And thank you for helping me where my memory failed)",
      "Please talk to more of my men and others to get their accounts as well!",
      "#customer1()"
            });

            _douglassDialogue = new Dialogue(new String[]
            {
                "Abraham Lincoln would like my help writing his address? Tell him to ask me himself!",
      "I only relay my information to ABOLITIONISTS!%I am one!|Okay, then.",
      "Really? You are an abolitionist?|#END",
      "Well I am not going to take that at face. I can find out easily if you are though one...",
      "First off, what PAPER am I the EDITOR for?%The Vindicator|The Liberator|The Times",
      "Not even close! Come back when you're a true Abolitionist!|An easy one.|Not even close! Come back when you are a true Abolitionist.",
      "#END|Okay, next one...|#END",
      "What is the name of one of the best ABOLITIONIST books?%Uncle Toms Cabin|A Tale of Two Cities",
      "Yes, another easy one...|Not even close! Try again when you are a true abolitionist!",
      "Okay, one last one...this time in two parts!|#END",
      "What did President Lincoln enact this year (1863)%Fugitive Slave Act|Emancipation Proclamation",
      "The exact opposite! Try again later!|Yes, yes.",
      "#END|And this frees all of the slaves-",
      "In what area?%Confederacy|Union|Both",
      "Yes! Correct!|Incorrect! Try again later.|Not yet, but we are trying! Try again later...",
      "It looks like you are a true ABOLITIONIST|#END|#END",
      "Here are my notes, please give them to the President.",
      "#gossip1()"
            });

            _lincolnDialogue = new Dialogue(new String[]
            {
                "Have you done what I need you to do?%Yes|No|What should I do?",
      "#startShipGame()|Let me know if you need help!|First, go get GENERAL MEADE'S account of the battle.",
      "Doesn't look like it!|I'll be here trying to write this speech.|Then, go ask Frederick Douglass to give me his notes!",
      "#END|#END|Help the reporters get the information they need about the battle!",
      "And finally, make sure you read all of the Newspapers around here!",
      "Get all of this done, and then I'll give you the EMANCIPATION PROCLAMATION"
            });


            _reporterDialogue = new Dialogue[5] { r1, r2, r3, r4, r5 };
            _graveDialogue = new Dialogue[6] { g1, g2, g3, g4, g5, g6 };
            _soldierDialogue = new Dialogue[10] { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10 };
            _abolitionistDialogue = new Dialogue[4] { a1, a2, a3, a4 };
            _newspaperDialogue = new Dialogue[3] { n1, n2, n3 };
        }

        public Dialogue GetReporterDialogue(int index)
        {
            return _reporterDialogue[index];
        }

        public Dialogue GetGraveDialogue(int index)
        {
            return _graveDialogue[index];
        }

        public Dialogue GetSoldierDialogue(int index)
        {
            return _soldierDialogue[index];
        }
        public Dialogue GetAbolitionistDialogue(int index)
        {
            return _abolitionistDialogue[index];
        }
        public Dialogue GetNewspaperDialogue(int index)
        {
            return _newspaperDialogue[index];
        }
        public Dialogue GetMeadeDialogue()
        {
            return _meadeDialogue;
        }
        public Dialogue GetLincolnDialogue()
        {
            return _lincolnDialogue;
        }
        public Dialogue GetDouglassDialogue()
        {
            return _douglassDialogue;
        }
    }
}
