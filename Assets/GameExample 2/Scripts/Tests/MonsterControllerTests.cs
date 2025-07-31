using System.Security.Cryptography;
using GameExample_2.Scripts.Monsters;
using NUnit.Framework;

public class MonsterControllerTest
{
    [Test(Description = "產生指定血量的怪物")]
    public void CreateAMonster_With_Hp()
    {
        // arrange 安排你的環境

        // act 呼叫指定的行為/功能
        MonsterController.Instance.CreateMonster(234);

        // assert 驗證需求
        var monsterHpInfo = MonsterController.Instance.GetHpInfo();
        Assert.AreEqual(234 , monsterHpInfo.Hp);
    }

    [Test(Description = "對怪物造成傷害")]
    [TestCase(100 , 134 , Description = "扣血後血量大於0")]
    [TestCase(500 , 0 , Description = "扣血後血量小於0，血量最低應為0")]
    // ShouldHpEqual0_When_Damage_Over_Hp
    public void DealDamage_For_Monster(int damage , int expectedHp)
    {
        // arrange 安排你的環境 given
        MonsterController.Instance.CreateMonster(234);

        // act 呼叫指定的行為/功能 when
        MonsterController.Instance.TakeDamage(damage);

        // assert 驗證需求 then
        var monsterHpInfo = MonsterController.Instance.GetHpInfo();
        Assert.AreEqual(expectedHp , monsterHpInfo.Hp);
    }

    [Test]
    public void Add()
    {
        var result = Calculator.Add(1 , 2);

        Assert.AreEqual( 3 , result );
    }
}

public class Calculator
{
    public static int Add(int a , int b)
    {
        return a + b;
    }
}