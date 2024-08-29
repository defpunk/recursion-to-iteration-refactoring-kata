export default function fibonacci(input: number): number {
    if(input < 2){
        return input;
    }
    return fibonacci(input -1) + fibonacci(input -2);
}