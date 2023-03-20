import './App.css';
import HomeView from "./views/HomeView";
import FoodMenuView from './views/FoodMenuView';
import ContactView from './views/ContactView';
import {
  createBrowserRouter,
  RouterProvider,
} from "react-router-dom";

const router = createBrowserRouter([
  {
    path: "/",
    element: <HomeView/>,
  },
  {
    path: "/Foods",
    element: <FoodMenuView/>,
  },
  {
    path: "/Contact",
    element: <ContactView/>,
  },
]);

function App() {
  return (
    <RouterProvider router={router} />)
}

export default App;