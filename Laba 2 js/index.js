const functor = (value) => {
  return {
    of: (val) => functor(val),
    map: (func) => functor(func(value)),
    join: () => value,
  };
};

const context = (...arr) => {
  return {
    add: (elem) => {
      const updated = functor(arr)
        .map((x) => [...x, elem])
        .join();
      return context(...updated);
    },
    rem: (str) => {
      const updated = functor(arr)
        .map((x) => x.filter((y) => y !== str))
        .join();
      return context(...updated);
    },
    print: () => {
      return functor(arr).join();
    },
  };
};

// Изначальный контекст с историческими событиями
const history = context("World War I", "Moon Landing", "Cold War");

// Добавляем новые события
const updatedHistory = history
  .add("Fall of the Berlin Wall")
  .add("Fall of the Berlin Wall")
  .rem("Fall of the Berlin Wall");
console.log(updatedHistory.print()); 