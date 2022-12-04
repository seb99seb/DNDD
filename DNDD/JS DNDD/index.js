const baseUri = "https://localhost:7219/api/Creatures"
Vue.createApp({
    data() {
        return {
            gottenAPI: false,
            id: 1,
            transformId: 1,
            creaturesList: [],
            traits: "",
            actions: "",
            WildShapeUses: 2,
            MaxHP: null,
            CurrentHP: null,
            MyChallengeLevel: 0.25,
            Transformed: false
        }
    },
    methods: {
        startUp(){
            this.getCreatures()
            this.gottenAPI = true
        },
        getCreatures(){
            axios.get(baseUri)
            .then(response => (this.creaturesList = response.data))
        },
        fixLB(line){
            return line.replace(/(?:\r\n|\r|\n)/g, '<br>')
        },
        statCalc(num){
            if (num % 2 != 0){
                num--
            }
            let number = (num-10)/2
            if (number<=0){
                return number
            }
            else{
                return `+${number}`
            }
        },
        tHTML(textTrait){
            this.traits = textTrait
        },
        aHTML(textAction){
            this.actions = textAction
        },
        Minus(){
            if (this.WildShapeUses>0){
                this.WildShapeUses--
            }
        },
        Stuff(){
            this.Minus()
            this.transformId = this.id
            this.Transformed = true
        }
    }
}).mount("#app")