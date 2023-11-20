from entity.animal import Animal


class Zoo:
    def __init__(self, animals=None):
        if animals:
            self.__animals = animals
        else:
            self.__animals = []

    @property
    def size(self):
        return len(self.__animals)

    def get_animal(self, index):
        if isinstance(index, int) and 0 <= index < self.size:
            return self.__animals[index]

    def add(self, animal):
        if isinstance(animal, Animal):
            self.__animals.append(animal)

    def __str__(self):
        msg = "List of animals:"

        for i in range(self.size):
            msg += f"\n{i + 1}) " + str(self.__animals[i])

        return msg
