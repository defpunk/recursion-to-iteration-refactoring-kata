export default function factorial(input: number): number {
    if(input === 1){
        return 1;
    }
    return input * factorial(input -1);
}