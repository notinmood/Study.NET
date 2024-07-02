class Person {
    constructor(name, age) {
        this.name = name;
        this.age = age;
    }

    private name: string;
    private age: number;

    setName(name) {
        this.name = name;
    }

    getName() {
        return this.name;
    }
}