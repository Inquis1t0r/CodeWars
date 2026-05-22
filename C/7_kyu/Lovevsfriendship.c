int word_score (const char *word)
{
    int sum = 0;
    
    for (int i = 0; word[i] != '\0'; i++) {
        if (word[i] >= 'a' && word[i] <= 'z') {
            sum += (word[i] - 'a' + 1); 
        }
    }
    
    return sum;
}
