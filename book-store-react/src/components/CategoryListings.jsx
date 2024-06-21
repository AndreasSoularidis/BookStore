import CategoryList from "./CategoryList"
import categories from '../../categories.json'

const CategoryListings = () => {

  return (
    <section>
      <div className="container">
        <h2 className="text-center text-medium"><span className="text-highlight">Κατηγορίες</span></h2>
        <div className="grid-container">
          {categories.map((category) => (
            <CategoryList key={category.id} category = {category} />
          ))}
        </div>
      </div>
    </section>
  )
}

export default CategoryListings